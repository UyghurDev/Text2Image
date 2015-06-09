<%@ Page Language="C#" MasterPageFile="~/Common/Public.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Text2Image_Default" Title="تور يۈزىدىكى تېكىستتىن رەسىم ھاسىل قىلغۇچ(Text2Image)" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td style="text-align: center">
                <br />
               تېكىستتىن رەسىم ھاسىل قىلىش<br />
                Text to Image<br />
                <hr class="HorzentalLineHeader" dir="rtl" />
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <table align="center" cellpadding="0" dir="rtl" 
                    style="width: 800px; border-collapse: collapse; border: 1px solid #D5DDF3">
                    <tr>
                        <td>
                            خەت نۇسخىسى:</td>
                                            <td style="text-align: center" dir="ltr">
                                                <asp:DropDownList ID="ddlFonts" runat="server">
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                خەت چوڭلۇقى:</td>
                                            <td>
                                                <asp:DropDownList ID="ddlSize" runat="server">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" colspan="4">
                                                <div id="pnlText">
                                                    <asp:TextBox ID="txtText" runat="server" Height="200px" TextMode="MultiLine" 
                                                        Width="800px" CssClass="TextBox"></asp:TextBox>
                                                    
                                                    <div align="right" dir="rtl" 
                                                        style="font-size: x-small; background-color: #FFCC66;">
                                                        <i style="background-color: #FFCC66; width: 100%;">&nbsp;ئەسكەرتىش: مەزكۇر پروگرامما پەقەت بىر بەت ھەجىمدىكى تېكىسنىلا رەسىمگە 
                                                        ئايلاندۇرىدۇ. ناۋادا تېكىست سەل كۆپ بولسا خەت نۇسخىسىنى كىچىكلىتىپ كۆرۈڭ ياكى 
                                                        بۆلۈپ كىرگۈزۈڭ.</i></div>
                                                    
                                                    <asp:Button ID="btnBuiled" runat="server" onclick="btnBuiled_Click" 
                                                        Text="ھاسىل قىلىش" />
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" colspan="4">
                                                <asp:Image ID="imgText" runat="server" Height="1123px" Width="794px" 
                                                    BorderWidth="1px" />
                                            </td>
                                        </tr>
                                    </table>
                <br />
                <br />
                <br />
                مۇناسىۋەتلىك ئۇلىنىشلار<hr align="right" class="HorzentalLineLinks" />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

