SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pharmacy`
--

-- --------------------------------------------------------

--
-- Table structure for table `salesrecords`
--

CREATE TABLE `salesrecords` (
  `id` int(11) NOT NULL,
  `item` varchar(20) NOT NULL,
  `quantity` int(3) NOT NULL,
  `price` double NOT NULL,
  `date` varchar(10) NOT NULL,
  `time` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `stocktable`
--

CREATE TABLE `stocktable` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `item` varchar(20) NOT NULL,
  `quantity` int(3) NOT NULL,
  `description` varchar(30) NOT NULL,
  `date` varchar(20) NOT NULL,
  `time` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `salesrecords`
--
ALTER TABLE `salesrecords`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `stocktable`
--
ALTER TABLE `stocktable`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `salesrecords`
--
ALTER TABLE `salesrecords`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `stocktable`
--
ALTER TABLE `stocktable`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
