(ns leap)

(defn- divides? [number divisor]
  (zero? (mod number divisor)))

(defn leap-year? [year]
  (if (divides? year 100)
    (divides? year 400)
    (divides? year 4)))
