/*
MySQL Data Transfer
Source Host: localhost
Source Database: saga
Target Host: localhost
Target Database: saga
Date: 2008-5-20 ÏÂÎç 05:49:42
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for char
-- ----------------------------
DROP TABLE IF EXISTS `char`;
CREATE TABLE `char` (
  `charID` int(10) unsigned NOT NULL auto_increment,
  `account_id` int(10) unsigned NOT NULL default '0',
  `name` varchar(50) collate utf8_unicode_ci NOT NULL default '',
  `face` varchar(10) character set ascii NOT NULL default '',
  `details` varchar(12) character set ascii NOT NULL default '',
  `sex` tinyint(3) unsigned NOT NULL default '0',
  `race` tinyint(3) unsigned NOT NULL default '0',
  `job` tinyint(3) unsigned NOT NULL default '0',
  `cLevel` int(10) unsigned NOT NULL default '0',
  `jLevel` int(10) unsigned NOT NULL default '0',
  `cEXP` int(10) unsigned NOT NULL default '0',
  `jEXP` int(10) unsigned NOT NULL default '0',
  `pendingDeletion` tinyint(3) unsigned NOT NULL default '0',
  `validationKey` int(10) unsigned NOT NULL default '0',
  `HP` smallint(5) unsigned NOT NULL default '0',
  `maxHP` smallint(5) unsigned NOT NULL default '0',
  `SP` smallint(5) unsigned NOT NULL default '0',
  `maxSP` smallint(5) unsigned NOT NULL default '0',
  `LC` tinyint(3) unsigned NOT NULL default '0',
  `maxLC` tinyint(3) unsigned NOT NULL default '0',
  `LP` tinyint(3) unsigned NOT NULL default '0',
  `maxLP` tinyint(3) unsigned NOT NULL default '0',
  `str` tinyint(3) unsigned NOT NULL default '0',
  `dex` tinyint(3) unsigned NOT NULL default '0',
  `intel` tinyint(3) unsigned NOT NULL default '0',
  `con` tinyint(3) unsigned NOT NULL default '0',
  `luk` tinyint(3) unsigned NOT NULL default '0',
  `stpoints` tinyint(3) unsigned NOT NULL default '0',
  `slots` varchar(14) collate utf8_unicode_ci NOT NULL default '',
  `weaponName` varchar(24) collate utf8_unicode_ci NOT NULL default '',
  `weaponType` int(11) NOT NULL default '0',
  `GMLevel` int(5) unsigned NOT NULL default '0',
  `NumShortcuts` tinyint(3) unsigned NOT NULL default '0',
  `ShortcutIDs` varchar(96) collate utf8_unicode_ci NOT NULL default '',
  `mapID` tinyint(3) unsigned NOT NULL default '0',
  `worldID` tinyint(3) unsigned NOT NULL default '0',
  `x` float NOT NULL default '0',
  `y` float NOT NULL default '0',
  `z` float NOT NULL default '0',
  `yaw` int(10) unsigned NOT NULL default '0',
  `zeny` int(10) unsigned NOT NULL default '0',
  `save_map` tinyint(3) unsigned NOT NULL default '0',
  `save_x` float NOT NULL default '0',
  `save_y` float NOT NULL default '0',
  `save_z` float NOT NULL default '0',
  `sightRange` int(10) unsigned NOT NULL default '0',
  `maxMoveRange` int(10) unsigned NOT NULL default '0',
  `state` tinyint(3) unsigned NOT NULL default '0',
  `stance` tinyint(3) unsigned NOT NULL default '0',
  `guild` int(10) unsigned NOT NULL default '0',
  `party` int(10) unsigned NOT NULL default '0',
  `Scenario` int(10) unsigned NOT NULL default '0',
  `online` tinyint(3) unsigned NOT NULL default '0',
  `muted` tinyint(1) unsigned NOT NULL default '0',
  PRIMARY KEY  (`charID`),
  KEY `name` (`name`),
  KEY `account_id` (`account_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Table structure for inventory
-- ----------------------------
DROP TABLE IF EXISTS `inventory`;
CREATE TABLE `inventory` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `charID` int(10) unsigned NOT NULL default '0',
  `nameID` int(10) NOT NULL default '0',
  `creatorName` varchar(50) collate utf8_unicode_ci NOT NULL default '',
  `equip` tinyint(3) NOT NULL default '-1',
  `amount` tinyint(10) unsigned NOT NULL default '0',
  `durability` smallint(5) unsigned NOT NULL default '0',
  PRIMARY KEY  (`id`),
  KEY `charID` (`charID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Table structure for joblevel
-- ----------------------------
DROP TABLE IF EXISTS `joblevel`;
CREATE TABLE `joblevel` (
  `charID` int(10) unsigned NOT NULL,
  `job` tinyint(3) unsigned NOT NULL,
  `level` tinyint(3) unsigned NOT NULL,
  KEY `charID` (`charID`,`job`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for mail
-- ----------------------------
DROP TABLE IF EXISTS `mail`;
CREATE TABLE `mail` (
  `mailID` int(10) unsigned NOT NULL auto_increment,
  `sender` varchar(34) character set utf8 collate utf8_bin NOT NULL,
  `receiver` varchar(34) character set utf8 collate utf8_bin NOT NULL,
  `topic` varchar(40) character set utf8 collate utf8_bin NOT NULL,
  `date` varchar(30) character set utf8 collate utf8_bin NOT NULL,
  `content` varchar(402) character set utf8 collate utf8_bin NOT NULL,
  `read` tinyint(3) unsigned NOT NULL,
  `valid` tinyint(3) unsigned NOT NULL,
  `zeny` int(10) unsigned NOT NULL,
  `itemID` int(10) unsigned NOT NULL,
  `creator` varchar(36) character set utf8 collate utf8_bin NOT NULL,
  `stack` tinyint(3) unsigned NOT NULL,
  `durability` smallint(5) unsigned NOT NULL,
  PRIMARY KEY  (`mailID`),
  KEY `receiver` (`receiver`),
  KEY `sender` (`sender`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Table structure for mapinfo
-- ----------------------------
DROP TABLE IF EXISTS `mapinfo`;
CREATE TABLE `mapinfo` (
  `charID` int(10) unsigned NOT NULL,
  `map` tinyint(3) unsigned NOT NULL,
  `value` tinyint(3) unsigned NOT NULL,
  KEY `charID` (`charID`,`map`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for market
-- ----------------------------
DROP TABLE IF EXISTS `market`;
CREATE TABLE `market` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `item_id` int(10) unsigned NOT NULL,
  `item_type` tinyint(3) unsigned NOT NULL,
  `item_clv` tinyint(3) unsigned NOT NULL,
  `item_stack` tinyint(3) unsigned NOT NULL,
  `item_durability` smallint(5) unsigned NOT NULL,
  `owner` varchar(40) character set utf8 collate utf8_bin NOT NULL,
  `price` int(10) unsigned NOT NULL,
  `expire` varchar(40) collate utf8_unicode_ci NOT NULL,
  `comment` varchar(1024) character set utf8 collate utf8_bin NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Table structure for quest
-- ----------------------------
DROP TABLE IF EXISTS `quest`;
CREATE TABLE `quest` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `charID` int(10) unsigned NOT NULL,
  `questID` int(10) unsigned NOT NULL,
  `step` varchar(150) character set ascii collate ascii_bin NOT NULL,
  `type` tinyint(3) unsigned NOT NULL default '0',
  PRIMARY KEY  (`id`),
  KEY `charID` (`charID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Table structure for shortcuts
-- ----------------------------
DROP TABLE IF EXISTS `shortcuts`;
CREATE TABLE `shortcuts` (
  `charID` int(10) unsigned NOT NULL,
  `slotnumber` tinyint(3) unsigned NOT NULL,
  `type` tinyint(3) unsigned NOT NULL,
  `itemID` int(10) unsigned NOT NULL,
  KEY `charID` (`charID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Table structure for skills
-- ----------------------------
DROP TABLE IF EXISTS `skills`;
CREATE TABLE `skills` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `charID` int(10) unsigned NOT NULL,
  `type` tinyint(3) unsigned NOT NULL,
  `skillID` int(10) unsigned NOT NULL,
  `exp` int(10) unsigned NOT NULL,
  `slot` tinyint(3) unsigned NOT NULL default '0',
  PRIMARY KEY  (`id`),
  KEY `charID` (`charID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Table structure for storage
-- ----------------------------
DROP TABLE IF EXISTS `storage`;
CREATE TABLE `storage` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `charID` int(10) unsigned NOT NULL default '0',
  `nameID` int(10) NOT NULL default '0',
  `creatorName` varchar(50) collate utf8_unicode_ci NOT NULL default '',
  `equip` tinyint(3) NOT NULL default '-1',
  `amount` tinyint(10) unsigned NOT NULL default '0',
  `durability` smallint(5) unsigned NOT NULL default '0',
  PRIMARY KEY  (`id`),
  KEY `charID` (`charID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Table structure for weapon
-- ----------------------------
DROP TABLE IF EXISTS `weapon`;
CREATE TABLE `weapon` (
  `charID` int(10) unsigned NOT NULL,
  `name` varchar(24) character set utf8 collate utf8_unicode_ci NOT NULL,
  `level` tinyint(3) unsigned NOT NULL,
  `type` tinyint(3) unsigned NOT NULL,
  `augeSkillID` int(10) unsigned NOT NULL,
  `exp` int(10) unsigned NOT NULL,
  `durability` smallint(5) unsigned NOT NULL,
  `U1` tinyint(3) unsigned NOT NULL,
  `active` tinyint(3) unsigned NOT NULL,
  `slot1` int(10) unsigned NOT NULL,
  `slot2` int(10) unsigned NOT NULL,
  `slot3` int(10) unsigned NOT NULL,
  `slot4` int(10) unsigned NOT NULL,
  `slot5` int(10) unsigned NOT NULL,
  `slot6` int(10) unsigned NOT NULL,
  KEY `charID` (`charID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records 
-- ----------------------------
INSERT INTO `char` VALUES ('2', '3', 'yx166', '0101030111', '01010C010101', '1', '0', '1', '1', '1', '0', '0', '0', '542797754', '144', '250', '100', '100', '45', '45', '0', '5', '5', '3', '3', '2', '0', '0', '00000032320100', 'ds', '1', '1', '0', '', '3', '1', '-6558.26', '14842.2', '4322.33', '0', '0', '0', '0', '0', '0', '6000', '10000', '1', '3', '0', '0', '201', '0', '0');
INSERT INTO `char` VALUES ('3', '3', 'haha', '0C12010D12', '01010C010101', '1', '0', '1', '1', '1', '0', '0', '0', '286438998', '250', '250', '100', '100', '45', '45', '0', '5', '5', '3', '3', '2', '0', '0', '00000032320100', 'jk', '4', '1', '0', '', '11', '1', '-17393.7', '6504.06', '159.971', '0', '0', '0', '0', '0', '0', '6000', '10000', '0', '3', '0', '0', '201', '0', '0');
INSERT INTO `char` VALUES ('5', '3', 'letsgo', '011A010110', '01010C010101', '1', '0', '1', '2', '2', '48', '18', '0', '348659982', '112', '290', '100', '100', '45', '45', '0', '5', '5', '3', '3', '2', '0', '2', '00000032320100', 'gogo', '1', '1', '0', '', '3', '1', '14857.2', '6706.25', '2113.67', '0', '0', '3', '-4811.95', '15936', '3894', '6000', '10000', '0', '8', '0', '0', '201', '0', '0');
INSERT INTO `char` VALUES ('6', '3', 'gogo', '0117010116', '01010C010101', '1', '0', '1', '3', '3', '223', '95', '0', '1574774893', '119', '370', '100', '100', '45', '45', '2', '5', '9', '3', '3', '2', '0', '0', '00000032320100', 'kjs', '1', '1', '0', '', '3', '1', '2199.49', '21983.1', '3718.41', '0', '20', '3', '-4811.95', '15936', '3894', '6000', '10000', '0', '6', '0', '0', '201', '0', '0');
INSERT INTO `inventory` VALUES ('40', '2', '16061', '', '-1', '1', '0');
INSERT INTO `inventory` VALUES ('47', '3', '16097', '', '-1', '1', '0');
INSERT INTO `inventory` VALUES ('48', '3', '16061', '', '-1', '1', '0');
INSERT INTO `inventory` VALUES ('92', '5', '2666', 'Pukui', '-1', '1', '0');
INSERT INTO `inventory` VALUES ('113', '6', '51500002', 'Pukui', '-1', '2', '0');
INSERT INTO `inventory` VALUES ('114', '6', '2020000', 'Pukui', '-1', '3', '0');
INSERT INTO `inventory` VALUES ('115', '6', '2666', 'Pukui', '-1', '1', '0');
INSERT INTO `inventory` VALUES ('116', '6', '570270', 'Unripe PukuPuku', '-1', '1', '1070');
INSERT INTO `inventory` VALUES ('117', '6', '2603', 'Unripe PukuPuku', '-1', '1', '0');
INSERT INTO `mapinfo` VALUES ('1', '2', '128');
INSERT INTO `mapinfo` VALUES ('2', '2', '128');
INSERT INTO `mapinfo` VALUES ('3', '2', '128');
INSERT INTO `mapinfo` VALUES ('4', '2', '128');
INSERT INTO `mapinfo` VALUES ('5', '2', '128');
INSERT INTO `mapinfo` VALUES ('6', '2', '128');
INSERT INTO `quest` VALUES ('1', '6', '403', '0,40302,2,40303,2,40303,1,0', '1');
INSERT INTO `quest` VALUES ('4', '6', '402', '2,40201,1,40202,2,40202,0,0', '0');
INSERT INTO `skills` VALUES ('3', '2', '0', '1406901', '0', '0');
INSERT INTO `skills` VALUES ('4', '2', '0', '1407401', '0', '0');
INSERT INTO `skills` VALUES ('5', '3', '0', '1406901', '0', '0');
INSERT INTO `skills` VALUES ('9', '5', '0', '1406901', '0', '0');
INSERT INTO `skills` VALUES ('10', '5', '0', '1407401', '0', '0');
INSERT INTO `skills` VALUES ('11', '5', '0', '1407001', '0', '0');
INSERT INTO `skills` VALUES ('12', '6', '0', '1406901', '0', '0');
INSERT INTO `skills` VALUES ('13', '6', '0', '1407401', '0', '0');
INSERT INTO `skills` VALUES ('14', '6', '0', '1407001', '0', '0');
INSERT INTO `weapon` VALUES ('2', 'ds', '1', '1', '150001', '0', '1800', '1', '1', '0', '0', '0', '0', '0', '0');
INSERT INTO `weapon` VALUES ('3', 'jk', '1', '1', '150001', '0', '1800', '1', '1', '0', '0', '0', '0', '0', '0');
INSERT INTO `weapon` VALUES ('5', 'gogo', '1', '1', '150001', '6', '1744', '1', '1', '0', '0', '0', '0', '0', '0');
INSERT INTO `weapon` VALUES ('6', 'kjs', '1', '1', '150001', '18', '1669', '1', '1', '0', '0', '0', '0', '0', '0');
