   M S B A M L   `   `   `  ????O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   D @SampleWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SampleWPF	SampleWPF 5   	      SampleWPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   )localclr-namespace:SampleWPF     5   	      WindowsBackgroundBrush#???   5	   	     ? Title$  Main Window WPF??5
   	   $	??450??6!   $	??800??6.    ? Icon$ /Resources/Pikachu.jpg??6:    ? 
ResizeMode$ NoResize=?6X    ? WindowStartupLocation$ CenterScreen=?6n    ? 	Resources 5        strHelloWorld  WindowTitle  ComboBoxItems ?? Type ? Offset ? Color??%o  &	       &	 $     &	 T     &	  ?     ??5   
   Hello World!??69   ??5   
   This is a window string.??6C   ?? 5   
   " ??6(   .s?5      ??Item #1??6"   ??5      Item #2??6"   ??5      Item #3??6"   5      ?? 5   
   .??5      ? $ 0Q?6   $ Silver??6&   ? 5      $ 1Q?6   $
 Gray??6&   5      5      .??5      ? .+?5   
   ?? $??Center=?6   .+?5      ?? #??[ 6   $??20??6D   $	??100??6P   5       ?? 5"   
   $	??Top=?6   .+?5#      ?? -   5        $??
ButtonSamp??5#      $
??Bold"?6'   $??50??6N   $	??100??6Z   .??5$      ? .+?5%      ?? 
????  ?#??[ 62   ?? 5&      
???  ??#??[ 61   5'      5(      5)      ?? 5+   
   -   5        $??StackPanelSamp??5+      $??Bottom=?6+    5,        
LocalTitle??%9   &	       ??5-      This is a local string.??6I   5.      .+?5/      ?? -   5        $??ListBoxSamp??5/      $	??100??6)   $	??250??66   50      51      52      