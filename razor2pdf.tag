<?xml version='1.0' encoding='UTF-8' standalone='yes' ?>
<tagfile doxygen_version="1.8.20" doxygen_gitid="f246dd2f1c58eea39ea3f50c108019e4d4137bd5">
  <compound kind="class">
    <name>Sample::Pages::IndexModel</name>
    <filename>class_sample_1_1_pages_1_1_index_model.html</filename>
  </compound>
  <compound kind="interface">
    <name>NanoByte::Razor2Pdf::IPdfModel</name>
    <filename>interface_nano_byte_1_1_razor2_pdf_1_1_i_pdf_model.html</filename>
    <member kind="property">
      <type>string</type>
      <name>ViewPath</name>
      <anchorfile>interface_nano_byte_1_1_razor2_pdf_1_1_i_pdf_model.html</anchorfile>
      <anchor>a2fa1a8df1bfd742234417b455787f257</anchor>
      <arglist></arglist>
    </member>
  </compound>
  <compound kind="interface">
    <name>NanoByte::Razor2Pdf::IPdfRenderer</name>
    <filename>interface_nano_byte_1_1_razor2_pdf_1_1_i_pdf_renderer.html</filename>
    <member kind="function">
      <type>Task&lt; FileStreamResult &gt;</type>
      <name>RenderAsync&lt; T &gt;</name>
      <anchorfile>interface_nano_byte_1_1_razor2_pdf_1_1_i_pdf_renderer.html</anchorfile>
      <anchor>a8cdd36f442178e8a0a40a45c85c93ec5</anchor>
      <arglist>(string viewPath, T model)</arglist>
    </member>
    <member kind="function">
      <type>Task&lt; FileStreamResult &gt;</type>
      <name>RenderAsync</name>
      <anchorfile>interface_nano_byte_1_1_razor2_pdf_1_1_i_pdf_renderer.html</anchorfile>
      <anchor>a19f3b1229035d57a813b384cc48896fe</anchor>
      <arglist>(string viewPath)</arglist>
    </member>
    <member kind="function">
      <type>Task&lt; FileStreamResult &gt;</type>
      <name>RenderAsync&lt; T &gt;</name>
      <anchorfile>interface_nano_byte_1_1_razor2_pdf_1_1_i_pdf_renderer.html</anchorfile>
      <anchor>ad23d5acd5a74a609bc5e4df31e7f871f</anchor>
      <arglist>(T model)</arglist>
    </member>
  </compound>
  <compound kind="interface">
    <name>NanoByte::Razor2Pdf::IRazorViewRenderer</name>
    <filename>interface_nano_byte_1_1_razor2_pdf_1_1_i_razor_view_renderer.html</filename>
    <member kind="function">
      <type>Task&lt; string &gt;</type>
      <name>RenderAsync&lt; T &gt;</name>
      <anchorfile>interface_nano_byte_1_1_razor2_pdf_1_1_i_razor_view_renderer.html</anchorfile>
      <anchor>aa09e519e83559db9595fde4ceaf5e67c</anchor>
      <arglist>(string viewPath, T model)</arglist>
    </member>
  </compound>
  <compound kind="class">
    <name>NanoByte::Razor2Pdf::PdfRenderer</name>
    <filename>class_nano_byte_1_1_razor2_pdf_1_1_pdf_renderer.html</filename>
    <base>NanoByte::Razor2Pdf::IPdfRenderer</base>
    <member kind="function">
      <type>async Task&lt; FileStreamResult &gt;</type>
      <name>RenderAsync&lt; T &gt;</name>
      <anchorfile>class_nano_byte_1_1_razor2_pdf_1_1_pdf_renderer.html</anchorfile>
      <anchor>a0b9fa1470977a4e007a9671769fd1a92</anchor>
      <arglist>(string viewPath, T model)</arglist>
    </member>
    <member kind="function">
      <type>Task&lt; FileStreamResult &gt;</type>
      <name>RenderAsync</name>
      <anchorfile>class_nano_byte_1_1_razor2_pdf_1_1_pdf_renderer.html</anchorfile>
      <anchor>a1b14aca3de99137d8579de7f45fd5ff4</anchor>
      <arglist>(string viewPath)</arglist>
    </member>
    <member kind="function">
      <type>Task&lt; FileStreamResult &gt;</type>
      <name>RenderAsync&lt; T &gt;</name>
      <anchorfile>class_nano_byte_1_1_razor2_pdf_1_1_pdf_renderer.html</anchorfile>
      <anchor>a60fd21ad27fa912981bcead9ca094cda</anchor>
      <arglist>(T model)</arglist>
    </member>
  </compound>
  <compound kind="class">
    <name>Sample::Program</name>
    <filename>class_sample_1_1_program.html</filename>
  </compound>
  <compound kind="class">
    <name>NanoByte::Razor2Pdf::RazorViewRenderer</name>
    <filename>class_nano_byte_1_1_razor2_pdf_1_1_razor_view_renderer.html</filename>
    <base>NanoByte::Razor2Pdf::IRazorViewRenderer</base>
    <member kind="function">
      <type>async Task&lt; string &gt;</type>
      <name>RenderAsync&lt; T &gt;</name>
      <anchorfile>class_nano_byte_1_1_razor2_pdf_1_1_razor_view_renderer.html</anchorfile>
      <anchor>a600af07578756f20ab88132661cc0d83</anchor>
      <arglist>(string viewPath, T model)</arglist>
    </member>
  </compound>
  <compound kind="class">
    <name>Sample::Pages::ReportModel</name>
    <filename>class_sample_1_1_pages_1_1_report_model.html</filename>
    <base>NanoByte::Razor2Pdf::IPdfModel</base>
  </compound>
  <compound kind="class">
    <name>NanoByte::Razor2Pdf::ServiceCollectionExtensions</name>
    <filename>class_nano_byte_1_1_razor2_pdf_1_1_service_collection_extensions.html</filename>
    <member kind="function" static="yes">
      <type>static IServiceCollection</type>
      <name>AddRazor2Pdf</name>
      <anchorfile>class_nano_byte_1_1_razor2_pdf_1_1_service_collection_extensions.html</anchorfile>
      <anchor>a21f3f4754e6d10c9da742cff146f95a5</anchor>
      <arglist>(this IServiceCollection services)</arglist>
    </member>
  </compound>
  <compound kind="class">
    <name>Sample::Startup</name>
    <filename>class_sample_1_1_startup.html</filename>
  </compound>
  <compound kind="namespace">
    <name>NanoByte</name>
    <filename>namespace_nano_byte.html</filename>
    <namespace>NanoByte::Razor2Pdf</namespace>
  </compound>
  <compound kind="namespace">
    <name>NanoByte::Razor2Pdf</name>
    <filename>namespace_nano_byte_1_1_razor2_pdf.html</filename>
    <class kind="interface">NanoByte::Razor2Pdf::IPdfModel</class>
    <class kind="interface">NanoByte::Razor2Pdf::IPdfRenderer</class>
    <class kind="interface">NanoByte::Razor2Pdf::IRazorViewRenderer</class>
    <class kind="class">NanoByte::Razor2Pdf::PdfRenderer</class>
    <class kind="class">NanoByte::Razor2Pdf::RazorViewRenderer</class>
    <class kind="class">NanoByte::Razor2Pdf::ServiceCollectionExtensions</class>
  </compound>
  <compound kind="namespace">
    <name>Sample</name>
    <filename>namespace_sample.html</filename>
    <namespace>Sample::Pages</namespace>
    <class kind="class">Sample::Program</class>
    <class kind="class">Sample::Startup</class>
  </compound>
  <compound kind="namespace">
    <name>Sample::Pages</name>
    <filename>namespace_sample_1_1_pages.html</filename>
    <class kind="class">Sample::Pages::IndexModel</class>
    <class kind="class">Sample::Pages::ReportModel</class>
  </compound>
  <compound kind="page">
    <name>index</name>
    <title></title>
    <filename>index.html</filename>
    <docanchor file="index.html">md_D__a_Razor2Pdf_Razor2Pdf_doc_main</docanchor>
  </compound>
</tagfile>
