using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class Text2Image_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Fonts 
            string[] straFonts = new string[] { 
                "ALKATIP",
                "ALKATIP Asliye",
                "ALKATIP Basma",
                "ALKATIP Basma Tom",
                "ALKATIP Gezit",
                "ALKATIP Gezit Tom",
                "ALKATIP Jornal",
                "ALKATIP Jornal Tom",
                "ALKATIP Kitab",
                "ALKATIP Kitab Tom",
                "ALKATIP Kufi",
                "ALKATIP Marka",
                "ALKATIP Pinyin",
                "ALKATIP Rukki",
                "ALKATIP Talik",
                "ALKATIP Tor",
                "ALKATIP Tor Tom",
                "Arabic Typesetting",
                "Arial",
                "Microsoft Sans Serif",
                "Microsoft Uighur",
                "Tahoma",
                "UKIJ Basma",
                "UKIJ Chiwer Kesme",
                "UKIJ Esliye",
                "UKIJ Nasq",
                "UKIJ Ruqi",
                "UKIJ Tuz",
                "UKIJ Tuz Tom",
                "UKIJ Zilwa",
                "UKK KFA1",
                "UKK KFK1",
                "UKK RKA1",
                "UKK RKK1",
                "UKK TLA1",
                "UKK TLK1",
                "UKK TZA1",
                "UKK TZA2",
                "UKK TZA3",
                "UKK TZA4",
                "UKK TZK1",
                "UKK TZK2",
                "Times New Roman"
                };
                System.Collections.Generic.List<string> lstFonts=new System.Collections.Generic.List<string>(straFonts);

            ddlFonts.Items.Clear();
            ddlSize.Items.Clear();
            for (int nCount = 5; nCount < 73; nCount++)
            {
                ddlSize.Items.Add(new ListItem(nCount.ToString(), nCount.ToString()));

            }

            System.Drawing.Text.InstalledFontCollection ifnt = new System.Drawing.Text.InstalledFontCollection();
            foreach(System.Drawing.FontFamily fc in ifnt.Families)
            {
                if(lstFonts.Contains(fc.Name))
                {
                        ddlFonts.Items.Add(fc.Name);
                }
            }
            if (Session["Font"] != null)
            {
                ddlFonts.SelectedValue = Session["Font"].ToString();
            }
            if (Session["FontSize"] != null)
            {
                this.ddlSize.SelectedValue = Session["FontSize"].ToString();
            }
        }
    }
    protected void btnBuiled_Click(object sender, EventArgs e)
    {
        Session["Text"] = txtText.Text;
        Session["Font"] = ddlFonts.SelectedItem.Text;
        Session["FontSize"] = ddlSize.SelectedValue;
        imgText.ImageUrl = "Txt2Img.aspx";
    }
}
