( Hardware port assignments )

h# FF00 constant mult_a  \ no cambiar estos tres
h# FF02 constant mult_b  \ hacen parte de otras
h# FF04 constant mult_p  \ definiciones

\ memory map LVDS:
h# 6600 constant lvds_r1
h# 6602 constant lvds_r2
h# 6604 constant lvds_r3
h# 6606 constant lvds_r4
h# 6608 constant lvds_r5
h# 660A constant lvds_r6
h# 660C constant lvds_r7
h# 660E constant lvds_r8

\ memory map multiplier:
h# 6700 constant multi_a	
h# 6702 constant multi_b
h# 6704 constant multi_init
h# 6706 constant multi_done
h# 6708 constant multi_pp_high
h# 670A constant multi_pp_low


\ memory map divider:
h# 6800 constant div_a		
h# 6802 constant div_b
h# 6804 constant div_init
h# 6806 constant div_done
h# 6808 constant div_c


\ memory map uart:
h# 6900 constant uart_data    \ escritura y lectura de datos que van a la uart
h# 6902 constant uart_busy    \ para lectura de uart (uart_busy)
h# 6904 constant uart_avail   \ dato valido

