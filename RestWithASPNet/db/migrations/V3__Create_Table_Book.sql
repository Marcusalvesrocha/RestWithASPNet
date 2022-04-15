CREATE TABLE IF NOT EXISTS `books`(
	`id` bigint(20) NOT NULL AUTO_INCREMENT,
    `title` LONGTEXT NOT NULL,
    `author` LONGTEXT NOT NULL,
    `launch_date` DATETIME NOT NULL,
    `price` DECIMAL NOT NULL,
    PRIMARY KEY (`id`)
);