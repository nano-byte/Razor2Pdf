namespace NanoByte.Razor2Pdf;

/// <summary>
/// Interface for Razor Page Models for use with by <see cref="PdfRenderer"/>.
/// </summary>
public interface IPdfModel
{
    /// <summary>
    /// The path of the Razor View associated with this model.
    /// </summary>
    string ViewPath { get; }
}
