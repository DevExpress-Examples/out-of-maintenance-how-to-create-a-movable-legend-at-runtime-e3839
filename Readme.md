<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128567840/11.2.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3839)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/SilverlightApplication1/MainPage.xaml) (VB: [MainPage.xaml](./VB/SilverlightApplication1/MainPage.xaml))
* [MainPage.xaml.cs](./CS/SilverlightApplication1/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/SilverlightApplication1/MainPage.xaml.vb))
<!-- default file list end -->
# How to create a movable legend at runtime
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3839)**
<!-- run online end -->


<p>This example shows how to provide the capability for end-users to move a chart's legend at runtime.</p><br />



<h3>Description</h3>

<p>For this, you need to assign a <a href="http://msdn.microsoft.com/en-us/library/system.windows.media.translatetransform(v=VS.95).aspx"><u>TranslateTransform</u></a> object (named <i>legendTransform</i>) to the <strong>Legend.RenderTransform</strong> property. This allows you to control and modify a legend position.</p><p>Before changing a legend position, you should handle the <strong>ChartControl.MouseLeftButtonDown</strong> and <strong>ChartControl.MouseLeftButtonUp</strong> events to make sure that a legend has been dragged by a mouse. After that, it becomes possible to calculate a distance by which a <i>legendTransform</i> object should be moved. To accomplish this task, handle the <strong>ChartControl.MouseMove</strong> event.</p><br />
<br />


<br/>


