fact :: Integer -> Integer -> [Integer] -> [Integer]
fact n m xs
	| n < m = xs
	| (mod n m == 0) = fact (n `div` m) 2 (m:xs)
	| otherwise = fact n (m+1) xs