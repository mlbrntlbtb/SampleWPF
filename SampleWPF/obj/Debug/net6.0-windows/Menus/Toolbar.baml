   M S B A M L   `   `   `  ????D  @SampleWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SampleWPF.MenusSampleWPF.Menus  5   	       SampleWPF.Menus.Toolbar   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:SampleWPF.Menus     5   	     ? Title$  Toolbar??5   	   $	??200??6   $	??300??6&    J? CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$	 New??5      6'     5   
   -   5        $
 Open??5      6(     5   
   -   5        $
 Save??5      6(   .??5      ]? .+?5   
   `? $	??Top=?6   .?5      c? .@?5      ?? $	??New??6   $	??New??6'   ?? 5      $
??Open??6   $
??Open??6(   ?? 5      $
??Save??6   $
??Save??6(   ?? 5      ?? 5      .??6   
Font size:6$   ?? 5      .@?5      ?? .??6#   106'   ?? 5       ?? 
IsSelected$
 True??6#   .??65   1269   ?? 5      .??6#   146'   ?? 5      .??6#   166'   5      5      5      `? 5    
    `? Orientation$ Vertical=?6   $??Right=?6-   .?5!      c? .@?5"      ?? $	??Cut??6    ? ToolTip$( "Cut selection to windows clipboard??6'    c? OverflowMode$ Always=?6T   ??5#      ?? 5$      $??/Resources/cut.jpg??6    $??16??6<   $??16??6H   5&      ?? 5'      $
??Copy??6   $) #Copy selection to windows clipboard??6(   $ AsNeeded=?6V   ??5(      ?? 5)      $??/Resources/copy.png??6    $??16??6=   $??16??6I   5+      ?? 5,      $??Paste??6   $* $Paste selection to windows clipboard??6)   $ Never=?6X   ??5-      ?? 5.      $??/Resources/paste.png??6    $??16??6>   $??16??6J   50      51      52      ?? 53   
    ?? AcceptsReturn$
 True??6   54      55      