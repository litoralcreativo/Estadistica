# DLL con funciones estadisticas

## Media
A partir de un vector de `int` o `double`:
```cs
double Media(double[] muestra);
double Media(int[] muestra);
```

## Media Recortada
A partir de un vector de `int` o `double`, y un porcentaje `int` de recorte
```cs
double MediaRecortada(double[] muestra, int percent);
double MediaRecortada(int[] muestra, int percent);
```

## Mediana
A partir de un vector de `int` o `double`:
```cs
double Mediana(double[] muestra);
double Mediana(int[] muestra);
```

## Moda
A partir de un vector de `int` o `double` con la/s moda/s:
```cs
List<double> Moda(double[] muestra);
List<int> Moda(int[] muestra);
```

## Simetria de la distribucion
A partir de un vector de `double`:
```cs
DistributionSimetry Simetria(double [] muestra);
```

## Percentiles
A partir de un vector de `int` o `double` y un `int` (percentil)
```cs
double Percentil(double [] muestra, int percentil)
int Percentil(int[] muestra, int percentil)
```

## Cuartiles
#### No interpolados
A partir de un vector de `int` o `double` y un `int` (cuartil)
- Q1 = `Cuartil(muestra, 1)` = `Percentil(muestra, 25)`
- Q1 = `Cuartil(muestra, 2)` = `Percentil(muestra, 50)` = mediana
- Q1 = `Cuartil(muestra, 3)` = `Percentil(muestra, 75)`
```cs
double Cuartil(double[] muestra, int cuartil)
int Cuartil(int[] muestra, int cuartil)
```
#### Interpolados
A partir de un vector de `int` o `double`, devuelve un `double[3]` donde:
- Q1 = `CuartilesInterpolados[0]` 
- Q2 = `CuartilesInterpolados[1]` = mediana
- Q3 = `CuartilesInterpolados[2]`
```cs
double[] CuartilesInterpolados(double[] muestra)
double[] CuartilesInterpolados(int[] muestra)
```