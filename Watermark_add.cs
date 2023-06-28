namespace ы_snippets.net
{
    public static partial class WatermarkUtils
    {
        public static void AddWatermark()
        {
            const string sourcePath = "../../TestData/test.pdf";
            const string watermarkImagePath = "../../TestData/test.jpg";
            var document = new Aspose.Pdf.Document(sourcePath);

            var watermarkArtifact = new Aspose.Pdf.WatermarkArtifact();
            watermarkArtifact.SetImage(new FileStream(watermarkImagePath, FileMode.Open));

            watermarkArtifact.ArtifactHorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
            watermarkArtifact.ArtifactVerticalAlignment = Aspose.Pdf.VerticalAlignment.Center;
            watermarkArtifact.Rotation = 15;
            watermarkArtifact.Opacity = 1;
            watermarkArtifact.IsBackground = true;
            document.Pages[1].Artifacts.Add(watermarkArtifact);

            // Save the resulting PDF to a file
            document.Save("result_with_watermark.pdf", Aspose.Pdf.SaveFormat.Pdf);
        }
    }
}
