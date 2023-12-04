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

-- Dumping structure for table qcu_attendance_db.admin_account
CREATE TABLE IF NOT EXISTS `admin_account` (
  `admin_id` int(100) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `employee_info` int(100) NOT NULL,
  PRIMARY KEY (`admin_id`) USING BTREE,
  KEY `employee_info` (`employee_info`),
  CONSTRAINT `FK_admin_account_employee_info` FOREIGN KEY (`employee_info`) REFERENCES `employee_info` (`employee_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.admin_account: ~1 rows (approximately)

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
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.employee_info: ~1 rows (approximately)
INSERT INTO `employee_info` (`employee_id`, `employee_code`, `first_name`, `middle_name`, `last_name`, `dob`, `gender`, `department_id`, `email`) VALUES
	(23, '23-9678', 'dasd', 'asdas', 'asdas', '2023-12-04', 'Female', 2, 'asd'),
	(24, '23-3876', 'asdsa', 'sadas', 'asdasasdas', '2023-12-04', 'Female', 2, 'asdsa'),
	(25, '23-8208', 'das', 'sda', 'asdw', '2023-12-04', 'Female', 2, 'asdas'),
	(26, '23-6019', 'dasd', 'das', 'dsa', '2023-12-04', 'Female', 2, 'asdsa');

-- Dumping structure for table qcu_attendance_db.employee_schedule
CREATE TABLE IF NOT EXISTS `employee_schedule` (
  `emp_schedule_id` int(11) NOT NULL,
  `employee_id` int(100) NOT NULL,
  `emp_branc_id` int(100) NOT NULL,
  `workdays` varchar(15) NOT NULL,
  `shift_start_time` time NOT NULL,
  `shift_end_time` time NOT NULL,
  `schedule_start_date` date NOT NULL,
  `schedule_end_date` date NOT NULL,
  PRIMARY KEY (`emp_schedule_id`),
  KEY `employee_id` (`employee_id`),
  KEY `emp_branc_id` (`emp_branc_id`),
  CONSTRAINT `FK_emloyee_schedule_qcu_branches` FOREIGN KEY (`emp_branc_id`) REFERENCES `qcu_branches` (`branch_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_employee_schedule_employee_info` FOREIGN KEY (`employee_id`) REFERENCES `employee_info` (`employee_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.employee_schedule: ~0 rows (approximately)

-- Dumping structure for table qcu_attendance_db.emp_attendance_in
CREATE TABLE IF NOT EXISTS `emp_attendance_in` (
  `emp_attendace_id` int(10) NOT NULL,
  `employee_id` int(10) NOT NULL,
  `date` date NOT NULL,
  `time_in` time NOT NULL,
  `time_out` time NOT NULL,
  `over_time_in` time NOT NULL,
  `over_time_out` time NOT NULL,
  PRIMARY KEY (`emp_attendace_id`),
  KEY `employee_id` (`employee_id`),
  CONSTRAINT `FK_emp_attendance_in_employee_info` FOREIGN KEY (`emp_attendace_id`) REFERENCES `employee_info` (`employee_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.emp_attendance_in: ~0 rows (approximately)

-- Dumping structure for table qcu_attendance_db.qcu_branches
CREATE TABLE IF NOT EXISTS `qcu_branches` (
  `branch_id` int(11) NOT NULL,
  `branch_name` varchar(250) NOT NULL,
  `branch_address` varchar(250) NOT NULL,
  PRIMARY KEY (`branch_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.qcu_branches: ~4 rows (approximately)
INSERT INTO `qcu_branches` (`branch_id`, `branch_name`, `branch_address`) VALUES
	(1, 'San Francisco', 'SDASDADSA'),
	(2, 'Batasan', 'asdsa'),
	(3, 'San Bartolome', 'sadsaasddgreht'),
	(4, 'San Beda', 'Porok');

-- Dumping structure for table qcu_attendance_db.qcu_department
CREATE TABLE IF NOT EXISTS `qcu_department` (
  `department_id` int(11) NOT NULL AUTO_INCREMENT,
  `department_name` varchar(250) NOT NULL,
  `department_desc` varchar(250) NOT NULL,
  PRIMARY KEY (`department_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.qcu_department: ~3 rows (approximately)
INSERT INTO `qcu_department` (`department_id`, `department_name`, `department_desc`) VALUES
	(1, 'new_department_name', 'Thishdasdasd'),
	(2, 'Physical Education', 'Math'),
	(3, 'Mathemathics', 'Science');

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

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `views`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `views` AS SELECT e.employee_id, e.first_name, e.last_name, e.middle_name, e.department_id, e.gender, e.email, e.dob, d.department_name 
FROM employee_info e JOIN qcu_department d ON e.department_id = d.department_id ;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
