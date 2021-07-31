# Small Statistical Library

## Mean (media)
From an `int` or `double` array:
```cs
double Media(double[] muestra);
double Media(int[] muestra);
```

## Truncated mean (media truncada)
From an `int` or `double` array, and an `int` percent of truncation
```cs
double MediaRecortada(double[] muestra, int percent);
double MediaRecortada(int[] muestra, int percent);
```

## Median (mediana)
From an `int` or `double` array:
```cs
double Mediana(double[] muestra);
double Mediana(int[] muestra);
```

## Mode (moda)
From an `int` or `double` array:
```cs
List<double> Moda(double[] muestra);
List<int> Moda(int[] muestra);
```

## Distribution (distribucion)
From an `int` or `double` array. It returns an `enum` type:
- `DistributionSimetry.NegativeSkew = -1`
- `DistributionSimetry.Symmetrical = 0`
- `DistributionSimetry.PositiveSkew = 1`
```cs
DistributionSimetry Simetria(double [] muestra);
```

## Percentile
From an `int` or `double` array and an `int` (percentile)
```cs
double Percentil(double [] muestra, int percentil)
int Percentil(int[] muestra, int percentil)
```

## Quartiles (cuartiles)
#### Not interpolated (no interpolados)
From an `int` or `double` array and an `int` (quartile)
- Q1 = `Cuartil(muestra, 1)` = `Percentil(muestra, 25)`
- Q1 = `Cuartil(muestra, 2)` = `Percentil(muestra, 50)` = median
- Q1 = `Cuartil(muestra, 3)` = `Percentil(muestra, 75)`
```cs
double Cuartil(double[] muestra, int cuartil)
int Cuartil(int[] muestra, int cuartil)
```
#### Interpolated (interpolados)
From an `int` or `double` array. It Returns a `double[3]` array, where:
- Q1 = `CuartilesInterpolados[0]` 
- Q2 = `CuartilesInterpolados[1]` = median
- Q3 = `CuartilesInterpolados[2]`
```cs
double[] CuartilesInterpolados(double[] muestra)
double[] CuartilesInterpolados(int[] muestra)
```