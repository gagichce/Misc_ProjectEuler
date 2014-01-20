findPrime :: Integer -> [Integer] -> Integer
findPrime n xs
	| length xs == 100001 = head xs
	| (isPrime n) = findPrime (n+1) (n : xs)
	| otherwise = findPrime (n+1) xs

isPrime :: Integer -> Bool
isPrime x = not $ any divisible $ takeWhile notTooBig [2..] where
     divisible y = x `mod` y == 0
     notTooBig y = y*y <= x