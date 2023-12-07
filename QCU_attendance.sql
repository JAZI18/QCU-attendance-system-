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


-- Dumping database structure for qcu_attendance_db
CREATE DATABASE IF NOT EXISTS `qcu_attendance_db` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `qcu_attendance_db`;

-- Dumping structure for view qcu_attendance_db.absent_emp
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `absent_emp` (
	`employee_id` INT(100) NOT NULL,
	`workday` ENUM('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday') NULL COLLATE 'utf8mb4_general_ci'
) ENGINE=MyISAM;

-- Dumping structure for table qcu_attendance_db.admin_account
CREATE TABLE IF NOT EXISTS `admin_account` (
  `admin_id` int(100) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `employee_info` int(100) NOT NULL,
  PRIMARY KEY (`admin_id`) USING BTREE,
  KEY `employee_info` (`employee_info`),
  CONSTRAINT `FK_admin_account_employee_info` FOREIGN KEY (`employee_info`) REFERENCES `employee_info` (`employee_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.admin_account: ~0 rows (approximately)

-- Dumping structure for table qcu_attendance_db.admin_settings
CREATE TABLE IF NOT EXISTS `admin_settings` (
  `sett_key` varchar(50) DEFAULT NULL,
  `sett_val` varchar(50) DEFAULT NULL,
  UNIQUE KEY `sett_key` (`sett_key`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.admin_settings: ~0 rows (approximately)
INSERT INTO `admin_settings` (`sett_key`, `sett_val`) VALUES
	('late', '10');

-- Dumping structure for table qcu_attendance_db.employee_info
CREATE TABLE IF NOT EXISTS `employee_info` (
  `employee_id` int(100) NOT NULL AUTO_INCREMENT,
  `employee_code` varchar(50) NOT NULL DEFAULT '',
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
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.employee_info: ~5 rows (approximately)
INSERT INTO `employee_info` (`employee_id`, `employee_code`, `first_name`, `middle_name`, `last_name`, `dob`, `gender`, `department_id`, `email`) VALUES
	(23, '23-9678', 'Super', 'Mario', 'Rarw', '2023-12-04', 'Female', 2, 'asd'),
	(24, '23-3876', 'captain', 'teemo', 'duty', '2023-12-04', 'Female', 2, 'asdsa'),
	(25, '23-8208', 'juan', 'dela', 'cruz', '2023-12-04', 'Female', 2, 'asdas'),
	(26, '23-6019', 'kath', 'niel', 'por eber', '2023-12-04', 'Female', 2, 'asdsa'),
	(27, 'ABC123', 'John', 'Wick', 'Cena', '1999-01-10', 'Male', 5, 'johnwick@gmail.com');

-- Dumping structure for table qcu_attendance_db.employee_schedule
CREATE TABLE IF NOT EXISTS `employee_schedule` (
  `emp_schedule_id` int(11) NOT NULL AUTO_INCREMENT,
  `employee_id` int(100) NOT NULL,
  `emp_branc_id` int(100) NOT NULL,
  `workday` enum('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday') DEFAULT NULL,
  `shift_start_time` time NOT NULL,
  `shift_end_time` time NOT NULL,
  `schedule_start_date` date NOT NULL,
  `schedule_end_date` date NOT NULL,
  PRIMARY KEY (`emp_schedule_id`),
  KEY `employee_id` (`employee_id`),
  KEY `emp_branc_id` (`emp_branc_id`),
  CONSTRAINT `FK_employee_schedule_employee_info` FOREIGN KEY (`employee_id`) REFERENCES `employee_info` (`employee_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_employee_schedule_qcu_branches` FOREIGN KEY (`emp_branc_id`) REFERENCES `qcu_branches` (`branch_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.employee_schedule: ~3 rows (approximately)
INSERT INTO `employee_schedule` (`emp_schedule_id`, `employee_id`, `emp_branc_id`, `workday`, `shift_start_time`, `shift_end_time`, `schedule_start_date`, `schedule_end_date`) VALUES
	(1, 26, 2, 'Tuesday', '01:00:00', '00:00:00', '0000-00-00', '0000-00-00'),
	(2, 24, 2, 'Monday', '12:58:37', '11:58:38', '2023-12-06', '2023-12-06'),
	(3, 26, 2, 'Wednesday', '01:00:00', '10:49:39', '2023-12-06', '2023-12-06');

-- Dumping structure for table qcu_attendance_db.emp_attendance_in
CREATE TABLE IF NOT EXISTS `emp_attendance_in` (
  `emp_attendace_id` int(10) NOT NULL AUTO_INCREMENT,
  `employee_id` int(10) NOT NULL,
  `date` date NOT NULL,
  `time_in` time NOT NULL,
  `time_out` time NOT NULL,
  `over_time_in` time NOT NULL,
  `over_time_out` time NOT NULL,
  PRIMARY KEY (`emp_attendace_id`),
  KEY `employee_id` (`employee_id`),
  CONSTRAINT `FK_emp_attendance_in_employee_info` FOREIGN KEY (`employee_id`) REFERENCES `employee_info` (`employee_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.emp_attendance_in: ~4 rows (approximately)
INSERT INTO `emp_attendance_in` (`emp_attendace_id`, `employee_id`, `date`, `time_in`, `time_out`, `over_time_in`, `over_time_out`) VALUES
	(1, 26, '2023-12-05', '01:00:00', '15:42:50', '00:00:00', '00:00:00'),
	(2, 26, '2023-12-06', '01:20:00', '05:00:00', '00:00:00', '00:00:00'),
	(3, 26, '2023-12-06', '01:33:01', '14:33:02', '14:33:03', '14:33:03'),
	(4, 24, '2023-12-10', '14:56:30', '14:56:31', '14:56:32', '14:56:33');

-- Dumping structure for function qcu_attendance_db.get_settings
DELIMITER //
CREATE FUNCTION `get_settings`(`sk` VARCHAR(50)
) RETURNS varchar(50) CHARSET utf8mb4 COLLATE utf8mb4_general_ci
BEGIN
    DECLARE res VARCHAR(50);

    SELECT sett_val INTO res
    FROM admin_settings
	 WHERE sett_key = sk
	 ;
    RETURN res;
END//
DELIMITER ;

-- Dumping structure for view qcu_attendance_db.late_emp
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `late_emp` (
	`employee_id` INT(10) NOT NULL,
	`att_date` DATE NOT NULL,
	`attendance_time` TIME NOT NULL,
	`schedule_time` TIME NOT NULL,
	`minutes_late` BIGINT(21) NULL,
	`attendance_day` VARCHAR(9) NULL COLLATE 'utf8mb4_general_ci',
	`work_day` ENUM('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday') NULL COLLATE 'utf8mb4_general_ci'
) ENGINE=MyISAM;

-- Dumping structure for table qcu_attendance_db.qcu_branches
CREATE TABLE IF NOT EXISTS `qcu_branches` (
  `branch_id` int(11) NOT NULL AUTO_INCREMENT,
  `branch_name` varchar(250) NOT NULL,
  `branch_address` varchar(250) NOT NULL,
  PRIMARY KEY (`branch_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.qcu_branches: ~3 rows (approximately)
INSERT INTO `qcu_branches` (`branch_id`, `branch_name`, `branch_address`) VALUES
	(1, 'San Francisco', 'SDASDADSA'),
	(2, 'Batasan', 'asdsa'),
	(3, 'San Bartolome', 'sadsaasddgreht');

-- Dumping structure for table qcu_attendance_db.qcu_department
CREATE TABLE IF NOT EXISTS `qcu_department` (
  `department_id` int(11) NOT NULL AUTO_INCREMENT,
  `department_name` varchar(250) NOT NULL,
  `department_desc` varchar(250) NOT NULL,
  PRIMARY KEY (`department_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.qcu_department: ~6 rows (approximately)
INSERT INTO `qcu_department` (`department_id`, `department_name`, `department_desc`) VALUES
	(1, 'new_department_name', 'department_description'),
	(2, 'Physical Education', 'Math'),
	(3, 'Mathemathics', 'Science'),
	(4, 'Information Technology', 'Computer Studies'),
	(5, 'Computer Science', 'Computer Studies'),
	(6, 'Hello', 'World'),
	(7, 'QCU Laboratory', 'Department');

-- Dumping structure for view qcu_attendance_db.total_emp
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `total_emp` (
	`TOTAL` BIGINT(21) NOT NULL
) ENGINE=MyISAM;

-- Dumping structure for view qcu_attendance_db.views
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `views` (
	`employee_id` INT(100) NOT NULL,
	`first_name` VARCHAR(50) NOT NULL COLLATE 'utf8mb4_general_ci',
	`last_name` VARCHAR(50) NOT NULL COLLATE 'utf8mb4_general_ci',
	`middle_name` VARCHAR(50) NOT NULL COLLATE 'utf8mb4_general_ci',
	`department_id` INT(11) NOT NULL,
	`gender` VARCHAR(55) NOT NULL COLLATE 'utf8mb4_general_ci',
	`email` VARCHAR(50) NOT NULL COLLATE 'utf8mb4_general_ci',
	`dob` DATE NOT NULL,
	`department_name` VARCHAR(250) NOT NULL COLLATE 'utf8mb4_general_ci'
) ENGINE=MyISAM;

-- Dumping structure for view qcu_attendance_db.vw_attendancelog
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vw_attendancelog` (
	`employee_id` INT(100) NOT NULL,
	`department_id` INT(11) NOT NULL,
	`first_name` VARCHAR(50) NOT NULL COLLATE 'utf8mb4_general_ci',
	`last_name` VARCHAR(50) NOT NULL COLLATE 'utf8mb4_general_ci',
	`date` DATE NOT NULL,
	`time_in` TIME NOT NULL,
	`time_out` TIME NOT NULL,
	`over_time_in` TIME NOT NULL,
	`over_time_out` TIME NOT NULL
) ENGINE=MyISAM;

-- Dumping structure for view qcu_attendance_db.vw_department
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vw_department` (
	`department_name` VARCHAR(250) NOT NULL COLLATE 'utf8mb4_general_ci',
	`department_desc` VARCHAR(250) NOT NULL COLLATE 'utf8mb4_general_ci'
) ENGINE=MyISAM;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `absent_emp`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `absent_emp` AS SELECT
s.employee_id,s.workday
FROM employee_schedule AS s
left JOIN emp_attendance_in AS a
ON s.employee_id = a.employee_id
WHERE a.employee_id is null ;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `late_emp`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `late_emp` AS SELECT
    a.employee_id ,
    a.date AS att_date,
    a.time_in AS attendance_time,
    s.shift_start_time AS schedule_time,
    TIMEstampDIFF(MINUTE, s.shift_start_time, a.time_in) AS minutes_late,
    DAYNAME(a.date) attendance_day,
    s.workday work_day
FROM
    emp_attendance_in a
jOIN
    employee_schedule s ON a.employee_id = s.employee_id 
    AND  DAYNAME(a.date) = s.workday 

HAVING  minutes_late >= get_settings("late") AND att_date = CURDATE() ;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `total_emp`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `total_emp` AS SELECT COUNT(*) TOTAL FROM employee_info ;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `views`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `views` AS SELECT e.employee_id, e.first_name, e.last_name, e.middle_name, e.department_id, e.gender, e.email, e.dob, d.department_name 
FROM employee_info e JOIN qcu_department d ON e.department_id = d.department_id ;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vw_attendancelog`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `vw_attendancelog` AS SELECT a.employee_id, a.department_id, a.first_name, a.last_name, b.date, b.time_in, b.time_out, b.over_time_in, b.over_time_out
FROM employee_info a
JOIN emp_attendance_in b ;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vw_department`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `vw_department` AS SELECT department_name, department_desc
FROM qcu_department ;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
