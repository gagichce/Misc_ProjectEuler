isPal [] = True
isPal (x:[]) = True
isPal xs = if ((head xs) == (last xs)) then isPal (tail (init xs)) else False

pal n = isPal (show n)

getPal = [x*y | x <- [100..999], y<-[100..999], pal (x*y)]