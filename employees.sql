SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `general`
-- ----------------------------
DROP TABLE IF EXISTS `general`;
CREATE TABLE `general` (
  `id` varchar(25) NOT NULL,
  `surname` varchar(55) NOT NULL,
  `name` varchar(55) NOT NULL,
  `fathername` varchar(55) NOT NULL,
  `position` varchar(55) NOT NULL,
  `about` text,
  `born` varchar(10) NOT NULL,
  `photo` varchar(120) NOT NULL,
  `number` varchar(13) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;