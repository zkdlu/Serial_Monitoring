   M S B A M L   `   `   `  ����K  GSerialMonitoring, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:SerialMonitoring.ViewModels.Entity"SerialMonitoring.ViewModels.Entity  5      I)clr-namespace:SerialMonitoring.ConvertersSerialMonitoring.Converters  5      G(clr-namespace:SerialMonitoring.ResourcesSerialMonitoring.Resources  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0895    /SerialMonitoring.Converters.PercentageConterter   percentageConverter9  3SerialMonitoring.Converters.PercentToPointConverter  percentToPointConverter7  1SerialMonitoring.Converters.BrushToColorConverter  brushToColoerConverterA  ;SerialMonitoring.Converters.PercentageToVisibilityConverter # percentageToVisibilityConverter<  6SerialMonitoring.Converters.PercentageToBrushConverter  percentageToBrushConverter5  /SerialMonitoring.Converters.FloatPaddingConvert  floatPaddingConvert9  3SerialMonitoring.Converters.PercentageSizeConverter  percentageSizeConverter  �� DataTypeC  =SerialMonitoring.ViewModels.Entity.MonitorGridEntityViewModel �� Path A� Rows A� ColumnsB  <SerialMonitoring.ViewModels.Entity.MonitorBarEntityViewModelC	  =SerialMonitoring.ViewModels.Entity.ChannelGridEntityViewModel �� Padding �� 
StartPoint �� EndPoint � Offset � Color	 �� 	Converter
 �Name `� 	Converter �� ElementName �� ConverterParameterB
  <SerialMonitoring.ViewModels.Entity.ChannelBarEntityViewModel�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      ?
viewmodels0clr-namespace:SerialMonitoring.ViewModels.Entity  5      7	converter)clr-namespace:SerialMonitoring.Converters  5      2local(clr-namespace:SerialMonitoring.Resources  5      %�  &	        &	      &	 &     &	 9     &	 L     &	 _     &	 r     (�� �     5      *, +)(�� �    5      *, +)(�� �    5&      *,	 +)7  7  7  7   7  7  7  (�� J
    5i      *,
 +)7  7  7  7  7  7  7   7     5      6$     5      6(     5      6&     5	      60     5
      6+     5      6$     5      6(   �� 5      "   6   .R�5   
   � $��0q�6   ��6   �� $ Monitor.Width���6?   �� $ Monitor.Height�.+�5      �� ��6   �� $ Channels���5      �� 5      .R�5      A� $ 2��6&   $ 3��6/   5      5      5      5      �� 5      "   6   .R�5   
   � $��0q�6   ��6   �� $ Monitor.Width���6?   �� $ Monitor.Height�.+�5      �� ��6   �� $ Channels���5      �� 5      .R�5      A� $ 6��6&   5       5"      5#      5$      �� 5&      "  	 6   .R�5'   
   � .+�5(      �� $��1q�6   
���   �$ 1q�6=   ._�5)      ]� ��. ��5*      �� 5+      $ 0.5,0&�6.   $ 0.5,1&�6A   .��5,      � $	 0.0Q�6�    6+   �� $ Channel.Rgb�8	   6�   � 5-      $ White��6+   $	 0.2Q�69   � 5.      $ White��6+   $	 0.8Q�69   5/      .+�51      � $	��Top=�6   .+�52      �� $��20,0,0,0q�6G   
���   �$��48(�53   /   $
��Bold"�6=   ��52   $   �� $ Channel.Name�53   =   54      �� 55      $��Bottom=�6   $��1q�65   
���   �._�56      � $
 parent��6   .+�57      �� $
��Left=�6(   ��58   "   �� 59   &   $ 0.5,0&�6:   $ 0.5,1&�6M   .��5:   *   � $ White��67   $ 0Q�6E   � 5;   *   $ White��67   $	 0.4Q�6E   � 5<   *   $	 0.8Q�6�    67   �� $ Channel.Rgb�8	  6�   5=   '   ��5?   "   `� 5@   &   8  .1�5A   *   �� $ Channel.Percentage�62   �� 5B   *   $ parent��62   $ ActualWidth�6G   5C   '   5E      �� 5F      $��0��6(   
���   �$��48(�5G   3   $
��Bold"�6A   $��20,0,0,0q�6S   $��Center=�5H       $
��Left=�6;   �� 5I      $��48(�5J   (   $
��Bold"�66   $��Center=�5K   (   $��Center=�6C   ��5I   (   �� $ Channel.Percentage�8	  ��5L   "   `� 5M   &   8  .1�5N   *   �� $ Channel.Percentage�62   �� 5O   *   $ Channel.AlertLimit�62   5P   '   5R      �� 5S      
���   �$��48(�5T   3   $
��Bold"�6A   $��0,0,20,0q�6S   $��Center=�5U       $��Right=�6;   ��5S   (   �� $ Channel.Max�5U   ;   5V      5W      � 5X      .+�5Y      �� $��96(�5Z   $   $
��Bold"�62   $��Center=�5[   $   $��Center=�6?   ��5Y   $   �� $ Channel.Value�8	  $ 2����5\      `� 5]   "   8  .1�5^   &   �� $ Channel.Percentage�6.   �� 5_   &   $ Channel.AlertLimit�6.   5`   #   5b      5c      5d      5e      5f      5g      �� 5i      "  
 6   .R�5j   
   � .+�5k      �� 
���   �$��1q�6)   $��1q�6=   ._�5l      ]� ��. ��5m      �� 5n      $ 0.5,0&�6.   $ 0.5,1&�6A   .��5o      � $	 0.0Q�6�    6+   �� $ Channel.Rgb�8	   6�   � 5p      $ White��6+   $	 0.2Q�69   � 5q      $ White��6+   $	 0.8Q�69   5r      .+�5u      �� $	��Top=�6!   .+�5v      �� $��	16,16,0,0q�6J   $
��Left=�5w   $   $	��Top=�6?   
���   �$��30(�5x   7   $
��Bold"�6E   ��5v   $   �� $ Channel.SubName�5x   E   �� 5y      $��0,0,8,8q�6G   $��Right=�5z   $   $	��Top=�6@   
���   �$��24(�5{   7   $
��Bold"�6E   ��5y   $   �� $ Channel.Unit�5{   E   �� 5|      $��0,0,8,8q�6�   $��Right=�5}   $   $	��Top=�6@   $��48(�5~   $   $
��Bold"�62   ��5|   $   �� $ Channel.Value�8	  $ 2����5      `� 5�   "   8  .1�5�   &   �� $ Channel.Percentage�6.   �� 5�   &   $ Channel.AlertLimit�6.   5�   #   5�      5�      �� 5�      $��20q�6   $��1q�6R   ��6)   �� $ Channel.Rgb�._�5�      � $
 parent��6   .+�5�      �� $��Bottom=�6(   ��5�   "   �� 5�   &   $ 0,0.5&�6:   $ 1,0.5&�6M   .��5�   *   � $ 0Q�6�    67   �� $ Channel.Rgb�8	  6�   � 5�   *   $ White��67   $	 0.4Q�6E   � 5�   *   $ White��67   $	 0.6Q�6E   � 5�   *   $ 1Q�6�    67   �� $ Channel.Rgb�8	  6�   5�   '   ��5�   "   `� 5�   &   8  .1�5�   *   �� $ Channel.Percentage�62   �� 5�   *   $ parent��62   $ ActualHeight�6G   5�   '   5�      �� 5�      $��0��6(   
���   �$��48(�5�   3   $
��Bold"�6A   $��0,0,0,20q�6S   $��Bottom=�5�       $��Center=�6;   �� 5�      $��48(�5�   (   $
��Bold"�66   $��Center=�5�   (   $��Center=�6C   ��5�   (   �� $ Channel.Percentage�8	  ��5�   "   `� 5�   &   8  .1�5�   *   �� $ Channel.Percentage�62   �� 5�   *   $ Channel.AlertLimit�62   5�   '   5�      �� 5�      
���   �$��48(�5�   3   $
��Bold"�6A   $��0,20,0,0q�6S   $	��Top=�5�       $��Center=�68   ��5�   (   �� $ Channel.Max�5�   8   5�      5�      5�      5�      5�      5�      5�      