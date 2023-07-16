/*
MySQL Data Transfer
Source Host: localhost
Source Database: sagalogin
Target Host: localhost
Target Database: sagalogin
Date: 2008-5-20 ÏÂÎç 05:49:50
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for login
-- ----------------------------
DROP TABLE IF EXISTS `login`;
CREATE TABLE `login` (
  `account_id` int(10) NOT NULL auto_increment,
  `username` varchar(25) collate utf8_unicode_ci NOT NULL default '',
  `password` varchar(50) collate utf8_unicode_ci NOT NULL default '',
  `sex` tinyint(3) unsigned NOT NULL default '1',
  `lastlogin` varchar(25) collate utf8_unicode_ci NOT NULL default '',
  `Banned` tinyint(3) NOT NULL default '0',
  PRIMARY KEY  (`account_id`),
  KEY `username` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Procedure structure for sagaLoginAddUser
-- ----------------------------
DROP PROCEDURE IF EXISTS `sagaLoginAddUser`;
DELIMITER ;;
CREATE DEFINER=`saga`@`localhost` PROCEDURE `sagaLoginAddUser`(
name varchar(25),
pass varchar(50),
gender tinyint(3),
last varchar(25))
BEGIN
INSERT INTO `login` (`username`,`password`,`sex`,`lastlogin`) VALUES (name,pass,gender,last);
END;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for sagaLoginGetAccountId
-- ----------------------------
DROP PROCEDURE IF EXISTS `sagaLoginGetAccountId`;
DELIMITER ;;
CREATE DEFINER=`saga`@`localhost` PROCEDURE `sagaLoginGetAccountId`(name varchar(20))
BEGIN
SELECT `account_id` FROM `login` WHERE `username`=name;
END;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for sagaLoginGetUser
-- ----------------------------
DROP PROCEDURE IF EXISTS `sagaLoginGetUser`;
DELIMITER ;;
CREATE DEFINER=`saga`@`localhost` PROCEDURE `sagaLoginGetUser`(name varchar(20))
BEGIN
SELECT * FROM `login` WHERE `username`=name LIMIT 1;
END;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for sagaLoginUpdateUser
-- ----------------------------
DROP PROCEDURE IF EXISTS `sagaLoginUpdateUser`;
DELIMITER ;;
CREATE DEFINER=`saga`@`localhost` PROCEDURE `sagaLoginUpdateUser`(
name varchar(25),
pass varchar(50),
gender tinyint(3),
last varchar(25))
BEGIN
UPDATE `login` SET `password`=pass, `sex`=gender, `lastlogin`=last WHERE `username`=name;
END;;
DELIMITER ;

-- ----------------------------
-- Records 
-- ----------------------------
INSERT INTO `login` VALUES ('1', 'hjk5211_M', 'ac860237b01a769005f289420c3d5c16', '1', '', '0');
INSERT INTO `login` VALUES ('2', 'wer5211_M', '7069391', '1', '', '0');
INSERT INTO `login` VALUES ('3', 'HJK5211', 'c860237b01a769005f289420c3d5c16', '1', '2008-5-20 17:27:47', '0');
