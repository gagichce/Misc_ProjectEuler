lookups = [('0', 0),('1', 1),('2', 2),('3', 3),('4', 4),('5', 5),('6', 6),('7', 7),('8',8),('9', 9)]

fifth :: Int
fifth = sum [ x | x <- [2..10000000], (isFive x) == x ]

isFive n = sum [(digitToInt x lookups)^5 | x <- show n ]

digitToInt n xs
	| n == first (head xs) = second (head xs)
	| otherwise = digitToInt n (tail xs)
	
first (a,_) = a
second (_,b) = b