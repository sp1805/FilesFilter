   M S B A M L   `   `   `  ����F  BFilesFilter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FilesFilterFilesFilter  5   	       FilesFilter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:FilesFilter     5   	     � Title$  FolderFilter��5   	   $��383.732��6   $
��1000��6/    � WindowStyle$ 
ToolWindow=�6<    � AllowsTransparency .   � 
ResizeMode$ NoResize=�6p   .��5	      �  J� RenderTransformOrigin$ 0.429,0.264&�6   $��-9,-28,0.6,-5.6q�6/   z�5
   
   V� 5      .~�5      �� �� 5       �� AngleX$ -3.5041414214731503E-15Q�6    �� 5       �� Angle$
 -0.0Q�6"   T� 5       T� X$ -0.342Q�6%    T� Y$ 0.102Q�60   5      	 � ColumnDefinitions	 5   
   �� 5      $
��130* �6   �� 5      $
��129* �6   .+�5   
   �� -   5        
 ��Name$
 FolderNameTB��5      $
��Left=�6(   $��66��6C   $��138,150,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $��Browse for Folder��6x   $	��Top=�6�   $	��423��6�   $��2��6�    �� 
IsReadOnly . 6�   �� 5   
   -   5         ��Name$ Browsebutton��5      $��	Browse...��6'   $��1��6;   $
��Left=�6K   $��128.6,152,0,0q�6f   $	��Top=�6}   $	��173��6�   $ 0.208,1.086&�6�   $��66��6�   z�5      V� 5      .~�5      �� �� 5      $ -3.5041414214731503E-15Q�6$   �� 5      $ -0.406Q�6&   T� 5      $ 0.273Q�6)   $ 0.357Q�63   5      5       �� 5!   
   -   5        $ Filterbutton��5!      $��2��6'   $��Start Filter��6;   $
��Left=�6R   $��406,268,0,0q�6m   $	��Top=�6�   $	��192��6�   $��62��6�   $ -0.036,0.592&�6�   6�   5#      5$      