   M S B A M L   `   `   `  ????D  @SampleWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:SampleWPF.UserControlsSampleWPF.UserControls  5      7    1SampleWPF.UserControls.UserControlForLabelTextBox   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:SampleWPF.UserControls     5      .??5	      ?   ? RowDefinitions  5
   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? ??6   ?? *Title+?? 5   
   $??1??6   .??5      ??  ?? Orientation$ 
Horizontal=?6   .+?5      ?? ??6   ??  ?? ElementName$ txtLimitedInput?? ?? Path$ Text.Length??? 5      $??/??6   ?? 5      ??6   ?? *	MaxLength+5      5      ?? 5   
   -   5        $??txtLimitedInput??5      $??1??6I   $??2??6V   $
??Auto=?6j    ?? TextWrapping$
 Wrap=?6?    ?? 	MaxLength 6)   ?? *	MaxLength+6?   5      5      