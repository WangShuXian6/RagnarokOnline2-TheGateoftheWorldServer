<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>ELFKISS-仙境传说II</title>
<style type="text/css">
</style>
</head>

<body>
<?php 
$dbcnx=@mysql_connect(localhost,root,root);  
if (!$dbcnx)
{
echo( "<P>无法与数据连接！解卡失败！</P>");
exit();
}
if(!@mysql_select_db("saga")) 
{
echo( "<P>没有找到相应数据表！解卡失败！</P>" );
exit();
}
$result = "UPDATE `char` SET `mapID`=5,`x`=13919,`y`=75806,`z`=5094 WHERE `name`='$HTTP_GET_VARS[name]'";
mysql_query($result);
if(mysql_affected_rows()>0) 
{ 
print "解卡成功！";
}else
{
print "解卡失败！";
print mysql_error();
} 
?> 
</form>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<center><h2><p>ELIFKISS-仙境传说II 解卡角色将会移动到首都</p></h2></center>
</body>
</html>
