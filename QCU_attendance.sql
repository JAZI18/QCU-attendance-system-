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

-- Dumping structure for table qcu_attendance_db.emloyee_schedule
CREATE TABLE IF NOT EXISTS `emloyee_schedule` (
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
  CONSTRAINT `FK_emloyee_schedule_employe_account` FOREIGN KEY (`employee_id`) REFERENCES `employe_account` (`employee_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_emloyee_schedule_qcu_branches` FOREIGN KEY (`emp_branc_id`) REFERENCES `qcu_branches` (`branch_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.emloyee_schedule: ~0 rows (approximately)
INSERT INTO `emloyee_schedule` (`emp_schedule_id`, `employee_id`, `emp_branc_id`, `workdays`, `shift_start_time`, `shift_end_time`, `schedule_start_date`, `schedule_end_date`) VALUES
	(1, 1, 1, 'Monday', '22:38:54', '34:38:54', '2023-11-17', '2023-11-30');

-- Dumping structure for table qcu_attendance_db.employee_info
CREATE TABLE IF NOT EXISTS `employee_info` (
  `employee_Id` int(100) NOT NULL,
  `employee_code` varchar(50) NOT NULL DEFAULT '',
  `first_name` varchar(50) NOT NULL DEFAULT '',
  `middle_name` varchar(50) NOT NULL DEFAULT '',
  `last_name` varchar(50) NOT NULL DEFAULT '',
  `dob` date NOT NULL,
  `gender` varchar(55) NOT NULL,
  `address` varchar(255) NOT NULL,
  `department_id` int(11) NOT NULL DEFAULT 0,
  `email` varchar(50) NOT NULL,
  PRIMARY KEY (`employee_Id`) USING BTREE,
  KEY `FK_employee_info_qcu_department` (`department_id`),
  CONSTRAINT `FK_employee_info_qcu_department` FOREIGN KEY (`department_id`) REFERENCES `qcu_department` (`department_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.employee_info: ~0 rows (approximately)
INSERT INTO `employee_info` (`employee_Id`, `employee_code`, `first_name`, `middle_name`, `last_name`, `dob`, `gender`, `address`, `department_id`, `email`) VALUES
	(1, '123', 'alexander', 'auguis', 'estares', '2023-11-01', 'Male', '#03 alton', 1, '');

-- Dumping structure for table qcu_attendance_db.employe_account
CREATE TABLE IF NOT EXISTS `employe_account` (
  `employee_id` int(100) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `employee_info` int(100) NOT NULL,
  PRIMARY KEY (`employee_id`) USING BTREE,
  KEY `employee_info` (`employee_info`),
  CONSTRAINT `FK_employe_account_employee_info` FOREIGN KEY (`employee_info`) REFERENCES `employee_info` (`employee_Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.employe_account: ~0 rows (approximately)
INSERT INTO `employe_account` (`employee_id`, `username`, `password`, `employee_info`) VALUES
	(1, 'lex', '123', 1);

-- Dumping structure for table qcu_attendance_db.emp_attence_in
CREATE TABLE IF NOT EXISTS `emp_attence_in` (
  `emp_attendace_id` int(10) NOT NULL,
  `employee_id` int(10) NOT NULL,
  `date` date NOT NULL,
  `time_in` time NOT NULL,
  `time_out` time NOT NULL,
  `over_time_in` time NOT NULL,
  `over_time_out` time NOT NULL,
  PRIMARY KEY (`emp_attendace_id`),
  KEY `employee_id` (`employee_id`),
  CONSTRAINT `FK_emp_attence_in_employe_account` FOREIGN KEY (`employee_id`) REFERENCES `employe_account` (`employee_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.emp_attence_in: ~0 rows (approximately)
INSERT INTO `emp_attence_in` (`emp_attendace_id`, `employee_id`, `date`, `time_in`, `time_out`, `over_time_in`, `over_time_out`) VALUES
	(1, 1, '2023-11-01', '13:34:11', '15:34:11', '20:34:11', '25:34:11');

-- Dumping structure for table qcu_attendance_db.qcu_branches
CREATE TABLE IF NOT EXISTS `qcu_branches` (
  `branch_id` int(11) NOT NULL,
  `branch_name` varchar(250) NOT NULL,
  `branch_address` varchar(250) NOT NULL,
  PRIMARY KEY (`branch_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Dumping data for table qcu_attendance_db.qcu_department: ~0 rows (approximately)
INSERT INTO `qcu_department` (`department_id`, `department_name`, `department_desc`) VALUES
	(1, 'Computer Science', 'Thishdasdasd');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;

