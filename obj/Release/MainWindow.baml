   M S B A M L   `   `   `  ���� K  GColumnCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ColumnCalculatorColumnCalculator  !    ColumnCalculator.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:ColumnCalculator       � Title$  Калькулятор��$	��450��$	��800�� � 
ResizeMode$ NoResize=�.���  � ColumnDefinitions �� �� .+�o� $
��Left=�$��19��$	��Top=�$	��792��$��2��.@�m� $��
Меню
��$��19��$	��100��.@�m� -   $��Выход
��$
��Left=�$��19��$	��130��4  .System.Windows.Automation.AutomationProperties   Name$
 Quit���� $��Первое число��$
��Left=�$��25��$��	10,24,0,0q�$	��Top=�$��89���� -    ��Name$ TextBox1��$
��Left=�$��83��$��	10,54,0,0q� �� TextWrapping$
 Wrap=�$��22.67��$	��Top=�$	��156��$��15(�" �� VerticalScrollBarVisibility$ Visible=�$ �� HorizontalScrollBarVisibility$ Visible=��� -    ��Name$ 	SignLabel��$��+��$
��Left=�$��28��$��
171,54,0,0q�$	��Top=�$��21��$��16(��� -   $ TextBox2��$
��Left=�$��83��$��
197,54,0,0q�$
 Wrap=�$	��4.5��$	��Top=�$	��156��$��15(�$ Visible=�$ Visible=��� $��Второе число��$
��Left=�$��25��$��
197,24,0,0q�$	��Top=�$��89���� -   	 ��Name$	 
PlusButton��$��+��$
��Left=�$��40��$��
36,173,0,0q�$	��Top=�$	��143��$��24(��� -   $	 MinusButton��$��-��$
��Left=�$��40��$��197,173,0,0q�$	��Top=�$	��143��$��24(��� -   $	 
MultButton��$��x��$
��Left=�$��40��$��
36,240,0,0q�$	��Top=�$	��143��$��24(��� -   $	 	DivButton��$��÷��$
��Left=�$��40��$��197,240,0,0q�$	��Top=�$	��143��$��24(��� -	   $ TextBox3��$��1��$
��Left=�$	��385��$��	10,24,0,0q�$
 Wrap=�$	��Top=�$	��376��$��24(�$9��3Решение отобразится здесь...��$ Visible=�$��Right=��� -
   $	 CleanButton��$!��Очистить вывод��$
��Left=�$��40��$��244,358,0,0q�$	��Top=�$	��143��$��17(�