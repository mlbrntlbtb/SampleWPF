   M S B A M L   `   `   `  ????D  @SampleWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SampleWPF.RichTextEditorSampleWPF.RichTextEditor  5   	   8    2SampleWPF.RichTextEditor.FlowDocumentTextAlignment   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:SampleWPF.RichTextEditor     5   	     ? Title$  FlowDocumentTextAlignment??5   	   $	??400??6+   $	??330??68    ? 	Resources 5	       ?? 
TargetType ?? Property ?? Value??%?   '/?       ?? 5
   
   " /?6   .?5      ?? ! ?@/?IsOptimalParagraphEnabled$
 True??6:   ?? 5       ?@/?IsHyphenationEnabled$
 True??65   5      5      .??5      ?? .+?5   
   ,? $
??Auto=?6#   .??5      /? .T?5      J? $??Italic$?6   $??14(?6/   
???????.*?6O   .*?5      By setting the ?? .?6   IsOptimalParagraphEnabled66   ?? property to true, you will allow WPF to look ahead on the lines to come, before deciding where to break. This will usually result in a more pleasant reading experience. It works especially well in combination with the ?? 5      .?6   IsHyphenationEnabled61   
 property.5      5      5      ,? 5   
   $
??Auto=?6#   .??5      /?   /? IsOptimalParagraphEnabled$
 True??6    /? IsHyphenationEnabled$
 True??6<   .T?5      J? $??Italic$?6   $??14(?6/   
???????.*?6O   .*?5       By setting the ?? .?6   IsOptimalParagraphEnabled66   ?? property to true, you will allow WPF to look ahead on the lines to come, before deciding where to break. This will usually result in a more pleasant reading experience. It works especially well in combination with the ?? 5$      .?6   IsHyphenationEnabled61   
 property.5%      5&      5'      5(      5)      