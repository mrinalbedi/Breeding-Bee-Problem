   M S B A M L   `   `   `  ����N  JBreedingBeesProblem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BreedingBeesProblemBreedingBeesProblem  5   	   $    BreedingBeesProblem.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:BreedingBeesProblem     5   	     � Title$  Breeding Bees��5   	   $	��400��6   $	��800��6,    � 
ResizeMode$ CanMinimize=�68    � Icon$ Resources/icon.png��6R   .��5	      � ��5
   
   �� 5       �� ImageSource$ Resources/background.jpg��6    �� Opacity$	 0.7Q�6@   6P    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $
��1.5* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   �� $��0��6   $��0��6"   $��2��62   .+�5      �� $��Source��6   ���#80719A$��20(�6:   $��Center=�6H   $��Center=�6j   �� 5      -   5        $��PathFromTexbox��5      $��60(�6,   $��Center=�6:   $��Center=�6\   $��10q�5   S   $	��150��6_    J� Opacity$	 0.6Q�6l    �� 	MaxLength$ 5��6z   ��6   �� *
PathFrom+6z   5      �� 5   
   $��0��6   $��1��6"   $��2��62   .+�5      �� $��Destination��6   ���#80719A$��20(�6?   $��Center=�6M   $��Center=�6o   �� 5      -   5        $��PathToTexbox��5      $��60(�6*   $��Center=�68   $��Center=�6Z   $��10q�5    Q   $	��150��6]   $	 0.6Q�6j   $ 5��6x   ��6   �� *PathTo+6x   5!      �� 5"   
   $��2��6   $��4��6#   $��10q�64   $	 0.6Q�6@   ��6N   �� *CellDistances+��5#      �� 5$      .R�5%      �  5&      �� 5'      �� 5(      �� 5)      �� 5*      �� 5+      �� 5,      .+�5.      �� $��0��6    $!��The distance between cells ��60   �� 5/      $��1��6    ��60   �� *Source+�� 50      $��2��6    $�� and ��60   �� 51      $��3��6    ��60   �� *Destination+�� 52      $��4��6    $
�� is ��60   �� 53      $��5��6    ��60   �� *
Distance+54      55      57      �� 58   
   $��2��6   $��0��6   $��2��6-   $��21(�6]   ���#8B7A9A$��Center=�6�   $��Center=�6�   ��6A   �� *	Message+6�   �� 59   
   -   5        $��	Calculate��59   l   $��3��6   $��0��6   ���#8B7A9A���#EADCC1$��0q�6X   $��	Calculate��6}   $��21(�6�   $��10 10q�6�   {�6�   �� *DisableButton+�� 5:   
   -   5        $
��Info��5:   X   $��3��6   $��1��6   ���#8B7A9A���#EADCC1$
��Info��6d   $��21(�6s   $��10 10q�6�   5;      5<      