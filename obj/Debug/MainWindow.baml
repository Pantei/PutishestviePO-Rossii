   M S B A M L   `   `   `  ����P  LPuteshestviePo Rossii, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PuteshestviePo_RossiiPuteshestviePo_Rossii  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 6;   &     PuteshestviePo_Rossii.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:PuteshestviePo_Rossii     5   	   6sys&clr-namespace:System;assembly=mscorlib     6;     � Title$.  (Путешествие по России��5   	   $	��600��6'   $
��1000��64   $	��600��6A   $
��1000��6Q    � 	Resources 5	         	NullImage��%R   &	        ��5
   
   0,pack://application:,,,/Resources/picture.png��5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��2* �6   6*   �� 5      $��5* �6   6*   �� 5      $
��0.5* �6   6,   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��5* �6#   60   �� 5      $��5* �6#   60   .+�5      A�  A� Columns$ 1��6    A� Rows$ 3��6&   $��0��6/   .+�5      �� $��Right=�6   $��Center=�64   $4��.Введите текст для поиска:��6O   6u   �� 5      $��Right=�6   $��Center=�64   $0��*Введите тип для поиска:��6O   6s   5      A� 5      $ 1��6   $ 3��6&   $��1��6/   .+�5      �� -   5         ��Name$ TxtFindedTourName��5      $��30��6a   $	��200��6m   $
��Left=�6y   6�   �� 5       -   5         ��Name$ CmbType��5       $��30��6X   $	��200��6d   $
��Left=�6p    �� DisplayMemberPath$
 Name��6�   6�   �� 5!      -   5        	 ��Name$	 	ChbActual��5!      $��30��6j   $	��200��6v   $
��Left=�6�   $0��*Только актуальные туры��6�   6�   5"      5#      �� 5$   
   -   5        
 ��Name$
 	ListTours��5$       $��1��6   $��Disabled=�63   $��Center=�6i   ��5%      �� 5&      .R�5'      � 5)      5*      ��5,      �� 5-      .R�5.      �� $��1q�6   
���   �._�5/      � $	��300��6   $	��200��6+    50      �� 51   "   $
��Auto �60   6@   �� 52   "   $��5* �60   6>   �� 53   "   $
��Auto �60   6@   �� 54   "   $
��Auto �60   6@   .+�56      �� $��0��6(   $��Center=�6K   $��Center=�6h   ��65   �� *Name+6�   �� 57      $��1��6$   $��Center=�6v   $��Center=�6�   ��61   �� *	ImgPath+ �� FallbackValue# [  6�   �� 58      $��2��6(   $��Center=�6T   $��Center=�6q   ��65   �� *FullViewPrice+6�   A� 59      $��3��6*   $ 1��67   $ 2��6@   .+�5:   "   �� $��Center=�6e   $��Center=�6�   ��6,   �� *State+��6C   �� *
colorBrush+6�   �� 5;   "   $��Center=�6M   $��Center=�6j   ��6,   �� *FullTicketCount+6�   5<      5=      5>      5?      5A      �� 5B   
   -   5         ��Name$ BtnShowHotelWindow��5B      $��2��6   $��
Отели��6:   $��Center=�6J   6�   5C      5D      