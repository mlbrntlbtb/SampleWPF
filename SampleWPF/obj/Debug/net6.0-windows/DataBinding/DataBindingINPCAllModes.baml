   M S B A M L   `   `   `  ????D  @SampleWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SampleWPF.DataBindingSampleWPF.DataBinding  5   	   3    -SampleWPF.DataBinding.DataBindingINPCAllModes   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SampleWPF.DataBinding     5   	     ? Title$  DataBindingINPCAllModes??5   	   $	??450??6)   $	??400??66   .??5
      ??  ?? Orientation$ Vertical=?6   $??10q?6)   $??0??65   .+?5   
   ?? $ 
Horizontal=?6   .+?5      ?? $??Name: ??6   ?? 5      ??6   ?? *Name+ ?? UpdateSourceTrigger$ PropertyChanged=?5      ?? 5   
   ??6   ?? *Name+ ?? Mode$ TwoWay=?$ PropertyChanged=??? 5   
   $ 
Horizontal=?6   .+?5      ?? $??	Address: ??6   ?? 5      ??6   ?? *	Address+$ PropertyChanged=?5      ?? 5   
   ??6   ?? *	Address+$ OneWayToSource=?$ PropertyChanged=??? 5   
   $ 
Horizontal=?6   .+?5      ?? $??Gender: ??6   ?? 5      ??6   ?? *Gender+$ PropertyChanged=?5      ?? 5   
   ??6   ?? *Gender+$ OneWay=?$ PropertyChanged=??? 5   
   $ 
Horizontal=?6   .+?5      ?? $??Contact #: ??6   ?? 5      ??6   ?? *	Contact+$ PropertyChanged=?5      ?? 5   
   ??6   ?? *	Contact+$ OneTime=?$ PropertyChanged=?5      5       