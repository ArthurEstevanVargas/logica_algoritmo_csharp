// Importações
using PdfSharpCore.Drawing;
using PdfSharpCore.Fonts;
using PdfSharpCore.Pdf;
using PdfSharpCore.Utils;

// ConfiguraçÕes de fonte
GlobalFontSettings.FontResolver = new FontResolver();

// Criar um novo documento
var document = new PdfDocument();

// Criar o objeto page, responsável pelas informações da página
var page = document.AddPage();

// Formatação do PDF: fontes, alinhamento, cores, etc...
var gfx = XGraphics.FromPdfPage(page);
var font = new XFont("Arial", 20, XFontStyle.Bold);
var textColor = XBrushes.Black;
var layout = new XRect(20, 20, page.Width, page.Height);
var format = XStringFormats.Center;

// Criar a página
gfx.DrawString("Hello World!", font, textColor, layout, format);

// Exportando arquivo PDF
document.Save("helloworld.pdf");