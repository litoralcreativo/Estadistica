# Small Statistical Library

## Mean (media)
```cs
double Media(double[] muestra);
double Media(int[] muestra);
```

## Truncated mean (media truncada)
```cs
double MediaRecortada(double[] muestra, int percent);
double MediaRecortada(int[] muestra, int percent);
```

## Median (mediana)
```cs
double Mediana(double[] muestra);
double Mediana(int[] muestra);
```

## Mode (moda)
```cs
List<double> Moda(double[] muestra);
List<int> Moda(int[] muestra);
```

## Distribution (distribucion)
- `DistributionSimetry.NegativeSkew = -1`
- `DistributionSimetry.Symmetrical = 0`
- `DistributionSimetry.PositiveSkew = 1`
```cs
DistributionSimetry Simetria(double [] muestra);
```

## Percentile
```cs
double Percentil(double [] muestra, int percentil)
int Percentil(int[] muestra, int percentil)
```

## Quartiles (cuartiles)
##### Not interpolated (no interpolados)
- Q1 = `Cuartil(muestra, 1)` = `Percentil(muestra, 25)`
- Q1 = `Cuartil(muestra, 2)` = `Percentil(muestra, 50)` = median
- Q1 = `Cuartil(muestra, 3)` = `Percentil(muestra, 75)`
```cs
double Cuartil(double[] muestra, int cuartil)
int Cuartil(int[] muestra, int cuartil)
```
##### Interpolated (interpolados)
- Q1 = `CuartilesInterpolados[0]` 
- Q2 = `CuartilesInterpolados[1]` = median
- Q3 = `CuartilesInterpolados[2]`
```cs
double[] CuartilesInterpolados(double[] muestra)
double[] CuartilesInterpolados(int[] muestra)
```

## Min and Max
```cs
double Min(double[] muestra)
double Max(double[] muestra)
int Min(int[] muestra)
int Max(int[] muestra)
```

## Range (rango)
```cs
double Rango(double[] muestra)
int Rango(int[] muestra)
```

## Standard Deviation (desviacion estandar)
```cs
double DesviacionEstandar (double[] muestra)
double DesviacionEstandar (int[] muestra)
```

## Variance (varianza)
```cs
double Varianza(double[] muestra)
double Varianza(int[] muestra)
```

## Variation Coefficient (coeficiente de variacion)
```cs
double CoeficienteDeVariacion (double[] muestra)
double CoeficienteDeVariacion(int[] muestra)
```