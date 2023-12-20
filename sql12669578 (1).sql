-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 20, 2023 at 09:45 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sql12669578`
--
CREATE DATABASE IF NOT EXISTS `sql12669578` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `sql12669578`;

-- --------------------------------------------------------

--
-- Stand-in structure for view `absent_emp`
-- (See below for the actual view)
--
DROP VIEW IF EXISTS `absent_emp`;
CREATE TABLE IF NOT EXISTS `absent_emp` (
`employee_id` int(100)
,`workday` enum('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday')
);

-- --------------------------------------------------------

--
-- Table structure for table `admin_account`
--

DROP TABLE IF EXISTS `admin_account`;
CREATE TABLE IF NOT EXISTS `admin_account` (
  `admin_id` int(100) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `employee_info` int(100) NOT NULL,
  PRIMARY KEY (`admin_id`) USING BTREE,
  KEY `employee_info` (`employee_info`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin_account`
--

REPLACE INTO `admin_account` (`admin_id`, `username`, `password`, `employee_info`) VALUES
(2, 'lex', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 23);

-- --------------------------------------------------------

--
-- Table structure for table `admin_settings`
--

DROP TABLE IF EXISTS `admin_settings`;
CREATE TABLE IF NOT EXISTS `admin_settings` (
  `sett_key` varchar(50) DEFAULT NULL,
  `sett_val` varchar(50) DEFAULT NULL,
  UNIQUE KEY `sett_key` (`sett_key`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin_settings`
--

REPLACE INTO `admin_settings` (`sett_key`, `sett_val`) VALUES
('late', '10');

-- --------------------------------------------------------

--
-- Table structure for table `batasan_present`
--

DROP TABLE IF EXISTS `batasan_present`;
CREATE TABLE IF NOT EXISTS `batasan_present` (
  `total` bigint(21) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `employee_info`
--

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
  KEY `FK_employee_info_qcu_department` (`department_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employee_info`
--

REPLACE INTO `employee_info` (`employee_id`, `employee_code`, `first_name`, `middle_name`, `last_name`, `dob`, `gender`, `department_id`, `email`) VALUES
('22-0556', '22-0556', 'Enerjhun', 'Quinanola', 'Relon', '1999-01-10', 'Male', 5, 'johnwick@gmail.com'),
('23-3876', '23-3876', 'Jereca Lyn', 'cuenca', 'Padauan', '2023-12-04', 'Female', 2, 'asdsa'),
('23-6019', '23-6019', 'james', 'quino', 'lim', '2023-12-04', 'Female', 2, 'asdsa'),
('23-6918', '23-6918', 'Charlie', 'Caspillo', 'Emprese', '2000-12-06', 'Optimus Prime', 4, 'jdcjdc@gmail.com'),
('23-8208', '23-8208', 'Jay Prince', 'Tulang', 'Mangmang', '2023-12-04', 'Female', 2, 'asdas'),
('23-8800', '', 'zaldrene', 'q', 'relon', '2023-12-20', 'Male', 5, 's'),
('23-9194', '', 'zzz', 'f', 'd', '2023-12-20', 'Male', 2, 't'),
('23-9678', '', 'Jazmine Mariz', 'biason', 'Madolid', '2023-12-04', 'Female', 2, 'asd');

-- --------------------------------------------------------

--
-- Table structure for table `employee_schedule`
--

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
  KEY `emp_branc_id` (`emp_branc_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `emp_attendance`
--

DROP TABLE IF EXISTS `emp_attendance`;
CREATE TABLE IF NOT EXISTS `emp_attendance` (
  `emp_attendace_id` int(10) NOT NULL AUTO_INCREMENT,
  `employee_id` varchar(20) NOT NULL,
  `workday` enum('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday') NOT NULL DEFAULT dayname(`date`),
  `date` date DEFAULT NULL,
  `time_in` time DEFAULT NULL,
  `time_out` time DEFAULT NULL,
  `over_time_in` time DEFAULT NULL,
  `over_time_out` time DEFAULT NULL,
  PRIMARY KEY (`emp_attendace_id`),
  KEY `employee_id` (`employee_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `emp_attendance`
--

REPLACE INTO `emp_attendance` (`emp_attendace_id`, `employee_id`, `workday`, `date`, `time_in`, `time_out`, `over_time_in`, `over_time_out`) VALUES
(1, '22-0556', 'Wednesday', '2023-12-20', '02:56:00', '02:56:00', '00:00:00', '00:00:00');

-- --------------------------------------------------------

--
-- Stand-in structure for view `emp_report`
-- (See below for the actual view)
--
DROP VIEW IF EXISTS `emp_report`;
CREATE TABLE IF NOT EXISTS `emp_report` (
`employee_id` int(100)
,`employee_Name` varchar(101)
,`branch_name` varchar(250)
,`workday` enum('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday')
,`att_date` date
,`attendance_time` time
,`departure_time` time
,`overtime_in` time
,`overtime_out` time
,`schedule_start_time` time
,`schedule_end_time` time
,`minutes_late` bigint(21)
,`minutes_early_departure` bigint(21)
);

-- --------------------------------------------------------

--
-- Table structure for table `face_recog`
--

DROP TABLE IF EXISTS `face_recog`;
CREATE TABLE IF NOT EXISTS `face_recog` (
  `id` int(11) DEFAULT NULL,
  `tracker` longblob DEFAULT NULL,
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Stand-in structure for view `late_emp`
-- (See below for the actual view)
--
DROP VIEW IF EXISTS `late_emp`;
CREATE TABLE IF NOT EXISTS `late_emp` (
`employee_id` int(10)
,`att_date` date
,`attendance_time` time
,`schedule_time` time
,`minutes_late` bigint(21)
,`attendance_day` varchar(9)
,`work_day` enum('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday')
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `present_emp`
-- (See below for the actual view)
--
DROP VIEW IF EXISTS `present_emp`;
CREATE TABLE IF NOT EXISTS `present_emp` (
`present` bigint(21)
);

-- --------------------------------------------------------

--
-- Table structure for table `qcu_branches`
--

DROP TABLE IF EXISTS `qcu_branches`;
CREATE TABLE IF NOT EXISTS `qcu_branches` (
  `branch_id` int(11) NOT NULL AUTO_INCREMENT,
  `branch_name` varchar(250) NOT NULL,
  `branch_address` varchar(250) NOT NULL,
  PRIMARY KEY (`branch_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `qcu_branches`
--

REPLACE INTO `qcu_branches` (`branch_id`, `branch_name`, `branch_address`) VALUES
(1, 'San Francisco', 'SDASDADSA'),
(2, 'Batasan', 'asdsa'),
(3, 'San Bartolome', 'sadsaasddgreht');

-- --------------------------------------------------------

--
-- Table structure for table `qcu_department`
--

DROP TABLE IF EXISTS `qcu_department`;
CREATE TABLE IF NOT EXISTS `qcu_department` (
  `department_id` int(11) NOT NULL AUTO_INCREMENT,
  `department_name` varchar(250) NOT NULL,
  `department_desc` varchar(250) NOT NULL,
  PRIMARY KEY (`department_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `qcu_department`
--

REPLACE INTO `qcu_department` (`department_id`, `department_name`, `department_desc`) VALUES
(1, 'new_department_name', 'department_description'),
(2, 'Physical Education', 'Math'),
(3, 'Mathemathics', 'Science'),
(4, 'Information Technology', 'Computer Studies'),
(5, 'Computer Science', 'Computer Studies'),
(6, 'Hello', 'World'),
(7, 'QCU Laboratory', 'Department');

-- --------------------------------------------------------

--
-- Stand-in structure for view `san_bartolome_present`
-- (See below for the actual view)
--
DROP VIEW IF EXISTS `san_bartolome_present`;
CREATE TABLE IF NOT EXISTS `san_bartolome_present` (
`total` int(1)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `total_emp`
-- (See below for the actual view)
--
DROP VIEW IF EXISTS `total_emp`;
CREATE TABLE IF NOT EXISTS `total_emp` (
`TOTAL` bigint(21)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `views`
-- (See below for the actual view)
--
DROP VIEW IF EXISTS `views`;
CREATE TABLE IF NOT EXISTS `views` (
`employee_id` int(100)
,`first_name` varchar(50)
,`last_name` varchar(50)
,`middle_name` varchar(50)
,`department_id` int(11)
,`gender` varchar(55)
,`email` varchar(50)
,`dob` date
,`department_name` varchar(250)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `vw_department`
-- (See below for the actual view)
--
DROP VIEW IF EXISTS `vw_department`;
CREATE TABLE IF NOT EXISTS `vw_department` (
`department_name` varchar(250)
,`department_desc` varchar(250)
);

-- --------------------------------------------------------

--
-- Structure for view `absent_emp`
--
DROP TABLE IF EXISTS `absent_emp`;

DROP VIEW IF EXISTS `absent_emp`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `absent_emp`  AS SELECT `s`.`employee_id` AS `employee_id`, `s`.`workday` AS `workday` FROM (`qcu_attendance_db`.`employee_schedule` `s` left join `qcu_attendance_db`.`emp_attendance` `a` on(`s`.`employee_id` = `a`.`employee_id`)) WHERE `a`.`employee_id` is null ;

-- --------------------------------------------------------

--
-- Structure for view `emp_report`
--
DROP TABLE IF EXISTS `emp_report`;

DROP VIEW IF EXISTS `emp_report`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `emp_report`  AS SELECT `e`.`employee_id` AS `employee_id`, concat(`e`.`first_name`,' ',`e`.`last_name`) AS `employee_Name`, `b`.`branch_name` AS `branch_name`, `s`.`workday` AS `workday`, `a`.`date` AS `att_date`, `a`.`time_in` AS `attendance_time`, `a`.`time_out` AS `departure_time`, `a`.`over_time_in` AS `overtime_in`, `a`.`over_time_out` AS `overtime_out`, `s`.`shift_start_time` AS `schedule_start_time`, `s`.`shift_end_time` AS `schedule_end_time`, CASE WHEN `a`.`workday` = `s`.`workday` THEN CASE WHEN timestampdiff(MINUTE,`s`.`shift_start_time`,`a`.`time_in`) < 0 THEN 0 ELSE timestampdiff(MINUTE,`s`.`shift_start_time`,`a`.`time_in`) END ELSE 0 END AS `minutes_late`, CASE WHEN `a`.`workday` = `s`.`workday` AND `a`.`time_out` <> '0000-00-00' THEN CASE WHEN timestampdiff(MINUTE,`a`.`time_out`,`s`.`shift_end_time`) < 0 THEN 0 ELSE timestampdiff(MINUTE,`a`.`time_out`,`s`.`shift_end_time`) END ELSE 0 END AS `minutes_early_departure` FROM (((`qcu_attendance_db`.`employee_schedule` `s` join `qcu_attendance_db`.`employee_info` `e` on(`s`.`employee_id` = `e`.`employee_id`)) left join `qcu_attendance_db`.`emp_attendance` `a` on(`a`.`employee_id` = `s`.`employee_id` and `a`.`workday` = `s`.`workday` and `a`.`date` between `s`.`schedule_start_date` and `s`.`schedule_end_date`)) left join `qcu_attendance_db`.`qcu_branches` `b` on(`b`.`branch_id` = `s`.`emp_branc_id`)) WHERE `a`.`time_in` is not null AND `a`.`time_out` is not null ;

-- --------------------------------------------------------

--
-- Structure for view `late_emp`
--
DROP TABLE IF EXISTS `late_emp`;

DROP VIEW IF EXISTS `late_emp`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `late_emp`  AS SELECT `a`.`employee_id` AS `employee_id`, `a`.`date` AS `att_date`, `a`.`time_in` AS `attendance_time`, `s`.`shift_start_time` AS `schedule_time`, timestampdiff(MINUTE,`s`.`shift_start_time`,`a`.`time_in`) AS `minutes_late`, dayname(`a`.`date`) AS `attendance_day`, `s`.`workday` AS `work_day` FROM (`qcu_attendance_db`.`emp_attendance` `a` join `qcu_attendance_db`.`employee_schedule` `s` on(`a`.`employee_id` = `s`.`employee_id` and dayname(`a`.`date`) = `s`.`workday`)) HAVING `minutes_late` >= `get_settings`('late') AND `att_date` = curdate() ;

-- --------------------------------------------------------

--
-- Structure for view `present_emp`
--
DROP TABLE IF EXISTS `present_emp`;

DROP VIEW IF EXISTS `present_emp`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `present_emp`  AS SELECT count(`emp_attendance`.`employee_id`) AS `present` FROM `emp_attendance` WHERE `emp_attendance`.`date` = curdate() ;

-- --------------------------------------------------------

--
-- Structure for view `san_bartolome_present`
--
DROP TABLE IF EXISTS `san_bartolome_present`;

DROP VIEW IF EXISTS `san_bartolome_present`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `san_bartolome_present`  AS SELECT 1 AS `total` ;

-- --------------------------------------------------------

--
-- Structure for view `total_emp`
--
DROP TABLE IF EXISTS `total_emp`;

DROP VIEW IF EXISTS `total_emp`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `total_emp`  AS SELECT count(0) AS `TOTAL` FROM `qcu_attendance_db`.`employee_info` ;

-- --------------------------------------------------------

--
-- Structure for view `views`
--
DROP TABLE IF EXISTS `views`;

DROP VIEW IF EXISTS `views`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `views`  AS SELECT `e`.`employee_id` AS `employee_id`, `e`.`first_name` AS `first_name`, `e`.`last_name` AS `last_name`, `e`.`middle_name` AS `middle_name`, `e`.`department_id` AS `department_id`, `e`.`gender` AS `gender`, `e`.`email` AS `email`, `e`.`dob` AS `dob`, `d`.`department_name` AS `department_name` FROM (`qcu_attendance_db`.`employee_info` `e` join `qcu_attendance_db`.`qcu_department` `d` on(`e`.`department_id` = `d`.`department_id`)) ;

-- --------------------------------------------------------

--
-- Structure for view `vw_department`
--
DROP TABLE IF EXISTS `vw_department`;

DROP VIEW IF EXISTS `vw_department`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_department`  AS SELECT `qcu_attendance_db`.`qcu_department`.`department_name` AS `department_name`, `qcu_attendance_db`.`qcu_department`.`department_desc` AS `department_desc` FROM `qcu_attendance_db`.`qcu_department` ;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `employee_info`
--
ALTER TABLE `employee_info`
  ADD CONSTRAINT `FK_employee_info_qcu_department` FOREIGN KEY (`department_id`) REFERENCES `qcu_department` (`department_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `employee_schedule`
--
ALTER TABLE `employee_schedule`
  ADD CONSTRAINT `FK_employee_schedule_employee_info` FOREIGN KEY (`employee_id`) REFERENCES `employee_info` (`employee_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `emp_attendance`
--
ALTER TABLE `emp_attendance`
  ADD CONSTRAINT `FK_emp_attendance_employee_info` FOREIGN KEY (`employee_id`) REFERENCES `employee_info` (`employee_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
