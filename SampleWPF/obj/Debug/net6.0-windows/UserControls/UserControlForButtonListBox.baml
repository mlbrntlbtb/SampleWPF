   M S B A M L   `   `   `  ????D  @SampleWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:SampleWPF.UserControlsSampleWPF.UserControls  5      8    2SampleWPF.UserControls.UserControlForButtonListBox   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:SampleWPF.UserControls     5      .??5	      ? 
???????  ? ColumnDefinitions  5
   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6   ?? 5      $
??Auto ?6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   .+?5   
   ?? $??0??6/   $
??Wrap=?6?   $
??Bold"?6S   ??6   ?? *	TextToAdd+6S   ?? 5   
    ?? Orientation$ 
Horizontal=?6   $??1??6.   .+?5      ?? -   5        $??	AddButton??5      $??1??6&   $??20??66   $??20??6B   ??5      ?? 5      $??/Resources/YES.jpg??6   $
??Fill=?68   5      ?? 5      -   5        $??DeleteButton??5      $??2??6)   $??20??69   $??20??6E   ??5      ?? 5      $??/Resources/NO.jpg??6   $
??Fill=?67   5      5      ?? 5   
   -   5        $??ListBoxCont??5      $??3??6%   5       5!      