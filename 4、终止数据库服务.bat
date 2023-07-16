@echo off
diskw\home\admin\program\pskill.exe mysqld-nt.exe c
diskw\home\admin\program\pskill.exe Apache.exe c
IF "%Disk%"=="" set Disk=w
subst "%Disk%": /D