   M S B A M L   `   `   `  ????D  @SampleWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SampleWPF.StylesSampleWPF.Styles  5   	   -    'SampleWPF.Styles.StyleTriggerAnimations   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:SampleWPF.Styles     5   	     ? Title$  StyleTriggerAnimations??5   	   $	??200??6(   $	??200??65    ? UseLayoutRounding$
 True??6A   .??5	      ? .+?5
   
   ?? 
???????$	??100??6)   $	??100??66   
??? ? ???5      ?? 5       ?? 
TargetType" ??6    ?? Triggers 5      P? 5       P? Property ?@J?IsMouseOver P? Value$
 True??69    N? EnterActions 5      ?? 5   "   .??5   &   ?? .??5   *   t?  g? Duration$ 	0:0:0.400D?6=    ?? TargetProperty$ BorderThickness?6R   		 t? To	 36~   W? 5   *   $ 	0:0:0.300D?6:   $ Height?6O   	
 W? To
 1256r   W? 5   *   $ 	0:0:0.300D?6:   $ Width?6O   
 1256q   5   '   5   #    N? ExitActions 5      ?? 5   "   .??5   &   ?? .??5   *   t? $ 	0:0:0.250D?6=   $ BorderThickness?6R   	 06~   W? 5   *   $ 	0:0:0.150D?6:   $ Height?6O   
 1006r   W? 5   *   $ 	0:0:0.150D?6:   $ Width?6O   
 1006q   5   '   5    #   5"      5$      5&      5'      5(      