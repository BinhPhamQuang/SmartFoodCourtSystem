using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFoodCourtSystem.DTO;
using Newtonsoft.Json.Linq;
using SmartFoodCourtSystem.DAO;

namespace SmartFoodCourtSystem
{
    public partial class UCMomo : UserControl
    {
         
        public event EventHandler ButtonClick;
        void Alert(string msg, FAlert.emType type)
        {
            FAlert frm = new FAlert();
            frm.showAlert(msg, type);

        }
        private string payurl = "";
        public bool paysuccessed = false;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public UCMomo()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            string endpoint = @"https://test-payment.momo.vn/gw_payment/transactionProcessor";
            string partnerCode = "MOMO5HQZ20200623";
            string accessKey = "Z4Qa3sv4hNWPxtFG";
            string serectkey = "J2c9EHI4m169OBpJGmUjJR2rfgi2y6kB";
            string orderInfo = "Order food";
            string returnUrl = @"https://facebook.com";
            string notifyurl = @"https://google.com";

            string amount = Cart.Instance.caculatePrice().ToString();
            string orderid = Guid.NewGuid().ToString();
            string requestId = Guid.NewGuid().ToString();
            string extraData = "";

            //Before sign HMAC SHA256 signature
            string rawHash = "partnerCode=" +
                partnerCode + "&accessKey=" +
                accessKey + "&requestId=" +
                requestId + "&amount=" +
                amount + "&orderId=" +
                orderid + "&orderInfo=" +
                orderInfo + "&returnUrl=" +
                returnUrl + "&notifyUrl=" +
                notifyurl + "&extraData=" +
                extraData;

            log.Debug("rawHash = " + rawHash);

            MoMoSecurity crypto = new MoMoSecurity();
            //sign signature SHA256
            string signature = crypto.signSHA256(rawHash, serectkey);
            log.Debug("Signature = " + signature);

            //build body json request
            JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "accessKey", accessKey },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderid },
                { "orderInfo", orderInfo },
                { "returnUrl", returnUrl },
                { "notifyUrl", notifyurl },
                { "extraData", extraData },
                { "requestType", "captureMoMoWallet" },
                { "signature", signature }

            };
            log.Debug("Json request to MoMo: " + message.ToString());
            string responseFromMomo = PaymentRequest.sendPaymentRequest(endpoint, message.ToString());

            JObject jmessage = JObject.Parse(responseFromMomo);
            log.Debug("Return from MoMo: " + jmessage.ToString());

            try
            {

                payurl = jmessage.GetValue("payUrl").ToString();
                wbMono.Navigate(jmessage.GetValue("payUrl").ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }
        public void Navigated()
        {
            if (wbMono.Url.AbsoluteUri != payurl)
            {

                wbMono.AllowNavigation = false;

                Alert("Successfully!", FAlert.emType.success);
                paysuccessed = true;
                BillDAO.Instance.createbill();
                Cart.Instance.DeleteCart();
            }
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void wbMono_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Navigated();
        }

        private void wbMono_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
