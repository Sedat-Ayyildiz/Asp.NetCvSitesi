using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Default : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBLHAKKIMDA.ToList();
            Repeater1.DataBind();

            Repeater2.DataSource = db.TBLHAKKIMDA.ToList();
            Repeater2.DataBind();

            Repeater3.DataSource = db.TBLHAKKIMDA.ToList();
            Repeater3.DataBind();

            Repeater4.DataSource = db.TBLYETENEKLER.ToList();
            Repeater4.DataBind();
        }

        protected void BtnGonder_Click(object sender, EventArgs e)
        {
            TBLILETISIM t = new TBLILETISIM();
            t.ADSOYAD = TxtAd.Text;
            t.MAIL = TxtMailAdresi.Text;
            t.KONU = TxtKonu.Text;
            t.MESAJ = TxtMesaj.Text;
            db.TBLILETISIM.Add(t);
            db.SaveChanges();
            TxtAd.Text = null;
            TxtMailAdresi.Text = null;
            TxtKonu.Text = null;
            TxtMesaj.Text = null;
        }

        protected void BtnVazgec_Click(object sender, EventArgs e)
        {
            TxtAd.Text = null;
            TxtMailAdresi.Text = null;
            TxtKonu.Text = null;
            TxtMesaj.Text = null;
        }
    }
}