: 0=    d# 0 = ;
: 1+    d# 1 + ;

: looptest  ( -- FIN )
    r>          ( xt )
    r>          ( xt i )
    1+
    r@ over =   ( xt i FIN )
    dup if
        nip r> drop
    else
        swap >r
    then        ( xt FIN )
    swap
    >r
;

: put-uart	\ hecho por el profe
    begin uart_busy @ 0= until
    uart_data !
;

: get-uart	\ hecho por el profe
    begin uart_avail @ d# 1 = until
    uart_data @
;

: lvds \ lvds
d# 1 lvds_enable !
;

: main 

h# FFFF
h# FFFF
h# FFFF
h# F800
h# F800
h# F800
h# 0180
h# 0180

lvds_r8 !
lvds_r7 !
lvds_r6 !
lvds_r5 !
lvds_r4 !
lvds_r3 !
lvds_r2 !
lvds_r1 !

do

\ get-uart dup put-uart
\ get-uart dup put-uart

\ multiplicar
\ dup
\ put-uart 
\ h# FF
\ dividir
\ put-uart

\ dup
\ put-uart
\ h# FF
\ dividir
\ put-uart

loop
;
