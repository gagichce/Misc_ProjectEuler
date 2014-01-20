max' n = if (isPrime n) && mod 600851475143 n == 0 then n else max' (n-1)

isPrime :: Integer -> Bool
isPrime n = primerHelper n 2
primerHelper n m = if m >= (squareRoot n) then True else (if mod n m == 0 then False else primerHelper n (m+1))

(^!) :: Num a => a -> Int -> a
(^!) x n = x^n
squareRoot :: Integer -> Integer
squareRoot 0 = 0
squareRoot 1 = 1
squareRoot n =
   let twopows = iterate (^!2) 2
       (lowerRoot, lowerN) =
          last $ takeWhile ((n>=) . snd) $ zip (1:twopows) twopows
       newtonStep x = div (x + div n x) 2
       iters = iterate newtonStep (squareRoot (div n lowerN) * lowerRoot)
       isRoot r  =  r^!2 <= n && n < (r+1)^!2
  in  head $ dropWhile (not . isRoot) iters