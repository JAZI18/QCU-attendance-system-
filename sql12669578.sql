-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.28-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             12.6.0.6765
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for sql12671822
DROP DATABASE IF EXISTS `sql12671822`;
CREATE DATABASE IF NOT EXISTS `sql12671822` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci */;
USE `sql12671822`;

-- Dumping structure for view sql12671822.absent_emp
DROP VIEW IF EXISTS `absent_emp`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `absent_emp` (
	`emp_branc_id` INT(100) NOT NULL,
	`employee_id` VARCHAR(20) NOT NULL COLLATE 'utf8mb4_general_ci',
	`workday` ENUM('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday') NULL COLLATE 'utf8mb4_general_ci'
) ENGINE=MyISAM;

-- Dumping structure for table sql12671822.admin_account
DROP TABLE IF EXISTS `admin_account`;
CREATE TABLE IF NOT EXISTS `admin_account` (
  `admin_id` int(100) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `employee_info` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`admin_id`) USING BTREE,
  KEY `employee_info` (`employee_info`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table sql12671822.admin_account: ~1 rows (approximately)
DELETE FROM `admin_account`;
INSERT INTO `admin_account` (`admin_id`, `username`, `password`, `employee_info`) VALUES
	(1, 'lex', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', '22');

-- Dumping structure for table sql12671822.admin_settings
DROP TABLE IF EXISTS `admin_settings`;
CREATE TABLE IF NOT EXISTS `admin_settings` (
  `sett_key` varchar(50) DEFAULT NULL,
  `sett_val` varchar(50) DEFAULT NULL,
  UNIQUE KEY `sett_key` (`sett_key`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table sql12671822.admin_settings: ~1 rows (approximately)
DELETE FROM `admin_settings`;
INSERT INTO `admin_settings` (`sett_key`, `sett_val`) VALUES
	('late', '10');

-- Dumping structure for view sql12671822.batasan_present
DROP VIEW IF EXISTS `batasan_present`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `batasan_present` (
	`total` BIGINT(21) NOT NULL
) ENGINE=MyISAM;

-- Dumping structure for table sql12671822.employee_info
DROP TABLE IF EXISTS `employee_info`;
CREATE TABLE IF NOT EXISTS `employee_info` (
  `employee_id` varchar(20) NOT NULL,
  `employee_code` varchar(20) NOT NULL DEFAULT '',
  `first_name` varchar(50) NOT NULL DEFAULT '',
  `middle_name` varchar(50) NOT NULL DEFAULT '',
  `last_name` varchar(50) NOT NULL DEFAULT '',
  `dob` date NOT NULL,
  `gender` varchar(55) NOT NULL,
  `department_id` int(11) NOT NULL DEFAULT 0,
  `email` varchar(50) NOT NULL,
  PRIMARY KEY (`employee_id`) USING BTREE,
  KEY `FK_employee_info_qcu_department` (`department_id`),
  CONSTRAINT `FK_employee_info_qcu_department` FOREIGN KEY (`department_id`) REFERENCES `qcu_department` (`department_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table sql12671822.employee_info: ~5 rows (approximately)
DELETE FROM `employee_info`;
INSERT INTO `employee_info` (`employee_id`, `employee_code`, `first_name`, `middle_name`, `last_name`, `dob`, `gender`, `department_id`, `email`) VALUES
	('22-0556', '22-0556', 'Enerjhun', 'Quinanola', 'Relon', '1999-01-10', 'Male', 5, 'johnwick@gmail.com'),
	('23-1899', '23-1899', 'erenjhun', 'quinanola', 'relon', '2023-12-22', 'Male', 3, 'erenjhun@gmail.com'),
	('23-6408', '', 'Jordan', 'Carvero', 'Mariano', '2003-02-18', 'Male', 4, 'zerefdamn11@gmail.com'),
	('23-6918', '23-6918', 'Charlie', 'Caspillo', 'Emprese', '2000-12-06', 'Optimus Prime', 4, 'jdcjdc@gmail.com'),
	('23-8208', '23-8208', 'Jay Prince', 'Tulang', 'Mangmang', '2023-12-04', 'Female', 2, 'asdas');

-- Dumping structure for table sql12671822.employee_schedule
DROP TABLE IF EXISTS `employee_schedule`;
CREATE TABLE IF NOT EXISTS `employee_schedule` (
  `emp_schedule_id` int(11) NOT NULL AUTO_INCREMENT,
  `employee_id` varchar(20) NOT NULL,
  `emp_branc_id` int(100) NOT NULL,
  `workday` enum('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday') DEFAULT NULL,
  `shift_start_time` time DEFAULT NULL,
  `shift_end_time` time DEFAULT NULL,
  `schedule_start_date` date DEFAULT NULL,
  `schedule_end_date` date DEFAULT NULL,
  PRIMARY KEY (`emp_schedule_id`),
  KEY `employee_id` (`employee_id`),
  KEY `emp_branc_id` (`emp_branc_id`),
  CONSTRAINT `FK_employee_schedule_employee_info` FOREIGN KEY (`employee_id`) REFERENCES `employee_info` (`employee_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_employee_schedule_qcu_branches` FOREIGN KEY (`emp_branc_id`) REFERENCES `qcu_branches` (`branch_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table sql12671822.employee_schedule: ~7 rows (approximately)
DELETE FROM `employee_schedule`;
INSERT INTO `employee_schedule` (`emp_schedule_id`, `employee_id`, `emp_branc_id`, `workday`, `shift_start_time`, `shift_end_time`, `schedule_start_date`, `schedule_end_date`) VALUES
	(7, '23-8208', 2, 'Thursday', '03:32:22', '04:11:10', '2023-12-08', '2023-12-25'),
	(21, '23-6408', 3, 'Tuesday', '01:01:01', '13:00:00', '2023-12-14', '2023-12-27'),
	(22, '23-8208', 1, 'Wednesday', '15:28:34', '15:28:34', '2023-12-22', '2023-12-22'),
	(24, '23-6918', 1, 'Monday', '01:00:00', '02:00:00', '2023-12-22', '2023-12-22'),
	(25, '23-6918', 1, 'Monday', '01:00:00', '02:00:00', '2023-12-22', '2023-12-22'),
	(27, '23-8208', 1, 'Monday', '07:00:00', '12:00:00', '2023-12-22', '2023-12-22'),
	(28, '23-1899', 2, 'Sunday', '07:00:00', '11:00:00', '2023-12-13', '2043-12-22');

-- Dumping structure for table sql12671822.emp_attendance
DROP TABLE IF EXISTS `emp_attendance`;
CREATE TABLE IF NOT EXISTS `emp_attendance` (
  `emp_attendace_id` int(10) NOT NULL AUTO_INCREMENT,
  `employee_id` varchar(20) NOT NULL,
  `branch_id` int(11) DEFAULT NULL,
  `workday` enum('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday') DEFAULT NULL,
  `date` date DEFAULT NULL,
  `time_in` time DEFAULT NULL,
  `time_out` time DEFAULT NULL,
  `over_time_in` time DEFAULT NULL,
  `over_time_out` time DEFAULT NULL,
  PRIMARY KEY (`emp_attendace_id`),
  KEY `employee_id` (`employee_id`) USING BTREE,
  KEY `branch_id` (`branch_id`),
  CONSTRAINT `FK_emp_attendance_employee_info` FOREIGN KEY (`employee_id`) REFERENCES `employee_info` (`employee_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_emp_attendance_qcu_branches` FOREIGN KEY (`branch_id`) REFERENCES `qcu_branches` (`branch_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table sql12671822.emp_attendance: ~2 rows (approximately)
DELETE FROM `emp_attendance`;
INSERT INTO `emp_attendance` (`emp_attendace_id`, `employee_id`, `branch_id`, `workday`, `date`, `time_in`, `time_out`, `over_time_in`, `over_time_out`) VALUES
	(1, '23-1899', 2, 'Sunday', '2023-12-24', '01:59:00', '01:59:00', NULL, NULL),
	(2, '23-1899', 2, 'Sunday', '2024-01-24', '14:22:44', '14:22:46', NULL, NULL);

-- Dumping structure for table sql12671822.emp_leave
DROP TABLE IF EXISTS `emp_leave`;
CREATE TABLE IF NOT EXISTS `emp_leave` (
  `leave_id` int(11) NOT NULL AUTO_INCREMENT,
  `employee_id` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `branch_id` int(11) DEFAULT NULL,
  `leave_date` date NOT NULL,
  PRIMARY KEY (`leave_id`),
  KEY `employee_id` (`employee_id`),
  KEY `branch_id` (`branch_id`),
  CONSTRAINT `FK_emp_leave_employee_info` FOREIGN KEY (`employee_id`) REFERENCES `employee_info` (`employee_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_emp_leave_qcu_branches` FOREIGN KEY (`branch_id`) REFERENCES `qcu_branches` (`branch_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Dumping data for table sql12671822.emp_leave: ~3 rows (approximately)
DELETE FROM `emp_leave`;
INSERT INTO `emp_leave` (`leave_id`, `employee_id`, `branch_id`, `leave_date`) VALUES
	(3, '22-0556', 1, '0000-00-00'),
	(4, '22-0556', 1, '2023-12-22'),
	(5, '23-6408', 1, '2023-12-22');

-- Dumping structure for view sql12671822.emp_leave_view
DROP VIEW IF EXISTS `emp_leave_view`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `emp_leave_view` (
	`Employee ID` VARCHAR(50) NOT NULL COLLATE 'utf8mb4_general_ci',
	`Name` VARCHAR(101) NOT NULL COLLATE 'utf8mb4_general_ci',
	`Branch` VARCHAR(250) NOT NULL COLLATE 'utf8mb4_general_ci',
	`Date` DATE NOT NULL
) ENGINE=MyISAM;

-- Dumping structure for view sql12671822.emp_report
DROP VIEW IF EXISTS `emp_report`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `emp_report` (
	`Employee ID` VARCHAR(20) NOT NULL COLLATE 'utf8mb4_general_ci',
	`Name` VARCHAR(101) NOT NULL COLLATE 'utf8mb4_general_ci',
	`Branch` VARCHAR(250) NULL COLLATE 'utf8mb4_general_ci',
	`Day` ENUM('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday') NULL COLLATE 'utf8mb4_general_ci',
	`Date` DATE NULL,
	`Time In` VARCHAR(8) NULL COLLATE 'utf8mb4_general_ci',
	`Time Out` VARCHAR(8) NULL COLLATE 'utf8mb4_general_ci',
	`Schedule Start Time` VARCHAR(8) NULL COLLATE 'utf8mb4_general_ci',
	`Schedule End Time` VARCHAR(8) NULL COLLATE 'utf8mb4_general_ci'
) ENGINE=MyISAM;

-- Dumping structure for view sql12671822.emp_sched_view
DROP VIEW IF EXISTS `emp_sched_view`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `emp_sched_view` (
	`Employee ID` VARCHAR(20) NOT NULL COLLATE 'utf8mb4_general_ci',
	`Full Name` VARCHAR(101) NOT NULL COLLATE 'utf8mb4_general_ci',
	`Branch` VARCHAR(250) NOT NULL COLLATE 'utf8mb4_general_ci',
	`Workday` ENUM('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday') NULL COLLATE 'utf8mb4_general_ci',
	`Shift Start Time` VARCHAR(8) NULL COLLATE 'utf8mb4_general_ci',
	`Shift End Time` VARCHAR(8) NULL COLLATE 'utf8mb4_general_ci',
	`Schedule Start Date` DATE NULL,
	`Schedule End Date` DATE NULL
) ENGINE=MyISAM;

-- Dumping structure for table sql12671822.face_recog
DROP TABLE IF EXISTS `face_recog`;
CREATE TABLE IF NOT EXISTS `face_recog` (
  `id` int(11) DEFAULT NULL,
  `tracker` longblob DEFAULT NULL,
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table sql12671822.face_recog: ~1 rows (approximately)
DELETE FROM `face_recog`;
INSERT INTO `face_recog` (`id`, `tracker`) VALUES

-- Dumping structure for function sql12671822.get_settings
DROP FUNCTION IF EXISTS `get_settings`;
DELIMITER //
CREATE FUNCTION `get_settings`(`sk` VARCHAR(50)) RETURNS varchar(50) CHARSET utf8mb4 COLLATE utf8mb4_general_ci
BEGIN
    DECLARE res VARCHAR(50);

    SELECT sett_val INTO res
    FROM admin_settings
	 WHERE sett_key = sk
	 ;
    RETURN res;
END//
DELIMITER ;

-- Dumping structure for view sql12671822.late_emp
DROP VIEW IF EXISTS `late_emp`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `late_emp` (
	`emp_branc_id` INT(100) NOT NULL,
	`employee_id` VARCHAR(20) NOT NULL COLLATE 'utf8mb4_general_ci',
	`att_date` DATE NULL,
	`attendance_time` TIME NULL,
	`schedule_time` TIME NULL,
	`minutes_late` BIGINT(21) NULL,
	`attendance_day` VARCHAR(9) NULL COLLATE 'utf8mb4_general_ci',
	`work_day` ENUM('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday') NULL COLLATE 'utf8mb4_general_ci'
) ENGINE=MyISAM;

-- Dumping structure for view sql12671822.present_emp
DROP VIEW IF EXISTS `present_emp`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `present_emp` (
	`employee_id` VARCHAR(20) NOT NULL COLLATE 'utf8mb4_general_ci',
	`emp_branc_id` INT(11) NULL,
	`att_date` DATE NULL
) ENGINE=MyISAM;

-- Dumping structure for table sql12671822.qcu_branches
DROP TABLE IF EXISTS `qcu_branches`;
CREATE TABLE IF NOT EXISTS `qcu_branches` (
  `branch_id` int(11) NOT NULL AUTO_INCREMENT,
  `branch_name` varchar(250) NOT NULL,
  `branch_address` varchar(250) NOT NULL,
  PRIMARY KEY (`branch_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table sql12671822.qcu_branches: ~3 rows (approximately)
DELETE FROM `qcu_branches`;
INSERT INTO `qcu_branches` (`branch_id`, `branch_name`, `branch_address`) VALUES
	(1, 'San Francisco', 'SDASDADSA'),
	(2, 'Batasan', 'asdsa'),
	(3, 'San Bartolome', 'sadsaasddgreht');

-- Dumping structure for table sql12671822.qcu_department
DROP TABLE IF EXISTS `qcu_department`;
CREATE TABLE IF NOT EXISTS `qcu_department` (
  `department_id` int(11) NOT NULL AUTO_INCREMENT,
  `department_name` varchar(250) NOT NULL,
  `department_desc` varchar(250) NOT NULL,
  PRIMARY KEY (`department_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table sql12671822.qcu_department: ~7 rows (approximately)
DELETE FROM `qcu_department`;
INSERT INTO `qcu_department` (`department_id`, `department_name`, `department_desc`) VALUES
	(1, 'new_department_name', 'department_description'),
	(2, 'Physical Education', 'Math'),
	(3, 'Mathemathics', 'Science'),
	(4, 'Information Technology', 'Computer Studies'),
	(5, 'Computer Science', 'Computer Studies'),
	(6, 'Hello', 'World'),
	(7, 'QCU Laboratory', 'Department');

-- Dumping structure for view sql12671822.san_bartolome_present
DROP VIEW IF EXISTS `san_bartolome_present`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `san_bartolome_present` (
	`total` BIGINT(21) NOT NULL
) ENGINE=MyISAM;

-- Dumping structure for view sql12671822.san_francisco_present
DROP VIEW IF EXISTS `san_francisco_present`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `san_francisco_present` (
	`total` BIGINT(21) NOT NULL
) ENGINE=MyISAM;

-- Dumping structure for view sql12671822.total_emp
DROP VIEW IF EXISTS `total_emp`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `total_emp` (
	`employee_id` VARCHAR(20) NOT NULL COLLATE 'utf8mb4_general_ci',
	`emp_branc_id` INT(11) NULL
) ENGINE=MyISAM;

-- Dumping structure for view sql12671822.views
DROP VIEW IF EXISTS `views`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `views` (
	`employee_id` VARCHAR(20) NOT NULL COLLATE 'utf8mb4_general_ci',
	`first_name` VARCHAR(50) NOT NULL COLLATE 'utf8mb4_general_ci',
	`last_name` VARCHAR(50) NOT NULL COLLATE 'utf8mb4_general_ci',
	`middle_name` VARCHAR(50) NOT NULL COLLATE 'utf8mb4_general_ci',
	`department_id` INT(11) NOT NULL,
	`gender` VARCHAR(55) NOT NULL COLLATE 'utf8mb4_general_ci',
	`email` VARCHAR(50) NOT NULL COLLATE 'utf8mb4_general_ci',
	`dob` DATE NOT NULL,
	`department_name` VARCHAR(250) NOT NULL COLLATE 'utf8mb4_general_ci'
) ENGINE=MyISAM;

-- Dumping structure for view sql12671822.vw_department
DROP VIEW IF EXISTS `vw_department`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vw_department` (
	`department_name` VARCHAR(250) NOT NULL COLLATE 'utf8mb4_general_ci',
	`department_desc` VARCHAR(250) NOT NULL COLLATE 'utf8mb4_general_ci'
) ENGINE=MyISAM;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `absent_emp`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `absent_emp` AS select `s`.`emp_branc_id` AS `emp_branc_id`,`s`.`employee_id` AS `employee_id`,`s`.`workday` AS `workday` from (`employee_schedule` `s` left join `emp_attendance` `a` on((`s`.`employee_id` = `a`.`employee_id`))) where isnull(`a`.`employee_id`) ;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `batasan_present`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `batasan_present` AS select count(distinct `es`.`employee_id`) AS `total` from (`employee_schedule` `es` join `qcu_branches` `qb` on((`es`.`emp_branc_id` = `qb`.`branch_id`))) where ((`es`.`workday` = dayname(curdate())) and (`qb`.`branch_name` = 'Batasan')) ;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `emp_leave_view`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `emp_leave_view` AS select `l`.`employee_id` AS `Employee ID`,concat(`i`.`first_name`,' ',`i`.`last_name`) AS `Name`,`b`.`branch_name` AS `Branch`,`l`.`leave_date` AS `Date` from ((`emp_leave` `l` join `employee_info` `i` on((`l`.`employee_id` = `i`.`employee_id`))) join `qcu_branches` `b` on((`b`.`branch_id` = `l`.`branch_id`))) ;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `emp_report`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `emp_report` AS select `e`.`employee_id` AS `Employee ID`,
concat(`e`.`first_name`,' ',`e`.`last_name`) AS `Name`
,`b`.`branch_name` AS `Branch`,
`s`.`workday` AS `Day`,
`a`.`date` AS `Date`,
time_format(`a`.`time_in`,'%h:%i %p') AS `Time In`,
time_format(`a`.`time_out`,'%h:%i %p') AS `Time Out`,
time_format(`s`.`shift_start_time`,'%h:%i %p') AS `Schedule Start Time`,
time_format(`s`.`shift_end_time`,'%h:%i %p') AS `Schedule End Time`
from (((`employee_schedule` `s` join `employee_info` `e` on((`s`.`employee_id` = `e`.`employee_id`))) 
left join `emp_attendance` `a` 
on(((`a`.`employee_id` = `s`.`employee_id`)  and (`a`.`date` between `s`.`schedule_start_date` and `s`.`schedule_end_date`)))) left join `qcu_branches` `b` on((`b`.`branch_id` = `s`.`emp_branc_id`))) where ((`a`.`time_in` is not null) and (`a`.`time_out` is not null)) ;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `emp_sched_view`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `emp_sched_view` AS select `es`.`employee_id` AS `Employee ID`,concat(`ei`.`first_name`,' ',`ei`.`last_name`) AS `Full Name`,`qb`.`branch_name` AS `Branch`,`es`.`workday` AS `Workday`,time_format(`es`.`shift_start_time`,'%l:%i %p') AS `Shift Start Time`,time_format(`es`.`shift_end_time`,'%l:%i %p') AS `Shift End Time`,`es`.`schedule_start_date` AS `Schedule Start Date`,`es`.`schedule_end_date` AS `Schedule End Date` from ((`employee_schedule` `es` join `employee_info` `ei` on((`es`.`employee_id` = `ei`.`employee_id`))) join `qcu_branches` `qb` on((`es`.`emp_branc_id` = `qb`.`branch_id`))) ;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `late_emp`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `late_emp` AS select `s`.`emp_branc_id` AS `emp_branc_id`,`a`.`employee_id` AS `employee_id`,`a`.`date` AS `att_date`,`a`.`time_in` AS `attendance_time`,`s`.`shift_start_time` AS `schedule_time`,timestampdiff(MINUTE,`s`.`shift_start_time`,`a`.`time_in`) AS `minutes_late`,dayname(`a`.`date`) AS `attendance_day`,`s`.`workday` AS `work_day` from (`emp_attendance` `a` join `employee_schedule` `s` on(((`a`.`employee_id` = `s`.`employee_id`) and (dayname(`a`.`date`) = `s`.`workday`)))) having ((`minutes_late` >= `get_settings`('late')) and (`att_date` = curdate())) ;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `present_emp`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `present_emp` AS select `a`.`employee_id` AS `employee_id`,`a`.`branch_id` AS `emp_branc_id`,`a`.`date` AS `att_date` from ((`employee_info` `i` join `emp_attendance` `a` on((`a`.`employee_id` = `i`.`employee_id`))) join `employee_schedule` `s` on(((`s`.`employee_id` = `i`.`employee_id`) and (`s`.`emp_branc_id` = `a`.`branch_id`) and (`s`.`workday` = `a`.`workday`)))) ;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `san_bartolome_present`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `san_bartolome_present` AS select count(0) AS `total` from ((`emp_attendance` `a` join `employee_schedule` `b` on((`a`.`employee_id` = `b`.`employee_id`))) join `qcu_branches` `c` on((`b`.`emp_branc_id` = `c`.`branch_id`))) where ((`a`.`date` = (curdate() + interval 1 day)) and (`b`.`emp_branc_id` = 3)) ;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `san_francisco_present`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `san_francisco_present` AS select count(0) AS `total` from ((`emp_attendance` `a` join `employee_schedule` `b` on((`a`.`employee_id` = `b`.`employee_id`))) join `qcu_branches` `c` on((`b`.`emp_branc_id` = `c`.`branch_id`))) where ((`a`.`date` = (curdate() + interval 1 day)) and (`b`.`emp_branc_id` = 1)) ;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `total_emp`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `total_emp` AS select `a`.`employee_id` AS `employee_id`,`a`.`branch_id` AS `emp_branc_id` from ((`employee_info` `i` join `emp_attendance` `a` on((`a`.`employee_id` = `i`.`employee_id`))) join `employee_schedule` `s` on(((`s`.`employee_id` = `i`.`employee_id`) and (`s`.`emp_branc_id` = `a`.`branch_id`)))) ;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `views`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `views` AS select `e`.`employee_id` AS `employee_id`,`e`.`first_name` AS `first_name`,`e`.`last_name` AS `last_name`,`e`.`middle_name` AS `middle_name`,`e`.`department_id` AS `department_id`,`e`.`gender` AS `gender`,`e`.`email` AS `email`,`e`.`dob` AS `dob`,`d`.`department_name` AS `department_name` from (`employee_info` `e` join `qcu_department` `d` on((`e`.`department_id` = `d`.`department_id`))) ;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vw_department`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `vw_department` AS select `qcu_department`.`department_name` AS `department_name`,`qcu_department`.`department_desc` AS `department_desc` from `qcu_department` ;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;