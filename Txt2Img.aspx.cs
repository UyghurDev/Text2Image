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
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;

/// <summary>
/// تېكىستتىن رەسىم ھاسىل قىلىش
/// <para>2008-11-28</para>
/// <para>سارۋان</para>
/// </summary>
public partial class Text2Image_Txt2Img : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BuildImage();
        }
    }

    private void BuildImage()
    {
        string strText = Session["Text"].ToString();
        int nLeft = 77;
        int nRight = 77;
        int nTop = 80;
        int nButtom = 50;
        System.Drawing.Size szPageSize = new Size(794, 1123);
        Rectangle recTextArea = new Rectangle(nLeft, nTop, 640, 1000);
        Size szTextArea = new Size(640, 1000);


        //point
        Point pntHeaderLineLeft = new Point(nLeft, 50);
        Point pntHeaderLineRight = new Point(nLeft + recTextArea.Width, 50);

        Point pntFooterLineLeft = new Point(nLeft, nTop + recTextArea.Height);
        Point pntFooterLineRight = new Point(nLeft + recTextArea.Width, nTop + recTextArea.Height);

        //fonts
        Font fntWebSite = new Font("Segoe UI", 9);
        Font fntHeader = new Font("ALKATIP Tor", 12);
        Font fntFooter = new Font("ALKATIP Tor", 9);
        string strMFontName = "";
        int nMFontSize = 9;
        if (Session["Font"] != null)
        {
            strMFontName=Session["Font"].ToString();
        }
        if (Session["FontSize"] != null)
        {
            nMFontSize=Convert.ToInt16(Session["FontSize"].ToString());
        }
        Font fntMainText = new Font(strMFontName, nMFontSize);
        
        //PrivateFontCollection pFont = new PrivateFontCollection();
        //pFont.AddFontFile(Application.StartupPath + "\\UKIJChiK.ttf");
        //System.Drawing.Font fnt = new Font(pFont.Families[0], 9);

        //color
        Color clrMaintText = Color.Black;
        Color clrWebSite = Color.Black;
        Color clrLine = Color.FromArgb(39, 173, 233);
        Color clrHeaderText = Color.Black;
        Color clrFooterText = Color.Black;

        //format
        StringFormat sfMainText = new StringFormat();
        sfMainText.FormatFlags = StringFormatFlags.DirectionRightToLeft;
        //TextFormatFlags tffMainText = new TextFormatFlags();
        //tffMainText = TextFormatFlags.WordBreak;

        //initalize
        //Size szMesure = TextRenderer.MeasureText(txtText.Text, fnt, szTextArea, TextFormatFlags.WordBreak);
        //if (szMesure.Height > recTextArea.Height)
        //{
        //    szPageSize.Height = szPageSize.Height + (szMesure.Height - szTextArea.Height);
        //    recTextArea.Height = szMesure.Height;
        //    pntFooterLineLeft.Y = nTop + recTextArea.Height;
        //    pntFooterLineRight.Y = nTop + recTextArea.Height;
        //}

        Bitmap objBitMap = new Bitmap(szPageSize.Width, szPageSize.Height);
        Graphics objGraph = Graphics.FromImage(objBitMap);
        objGraph.FillRectangle(new SolidBrush(Color.White), 0, 0, 794, 1123);
        //Draw line
        Pen pnLine = new Pen(clrLine, 5);
        objGraph.DrawLine(pnLine, pntHeaderLineLeft, pntHeaderLineRight);
        objGraph.DrawLine(pnLine, pntFooterLineLeft, pntFooterLineRight);



        //draw string
        objGraph.TextRenderingHint = TextRenderingHint.AntiAlias;
        objGraph.DrawString(strText, fntMainText, new SolidBrush(clrMaintText), recTextArea, sfMainText);
        objGraph.DrawString("ئۇيغۇر يۇمشاق دېتال ئىجادىيەت تورى", fntHeader, new SolidBrush(clrHeaderText), nLeft + recTextArea.Width, 25, sfMainText);
        objGraph.DrawString("http://lab.UyghurDev.net", fntWebSite, new SolidBrush(clrWebSite), 220, szPageSize.Height - 40, sfMainText);
        objGraph.DrawString("تور يۈزىدىكى تېكىستتىن رەسىم ھاسىل قىلغۇچ", fntFooter, new SolidBrush(clrHeaderText), nLeft + recTextArea.Width, szPageSize.Height - 40, sfMainText);
        Response.ContentType = "image/jpeg";
        objBitMap.Save(Response.OutputStream, ImageFormat.Jpeg);

        objBitMap.Dispose();
    }
}
