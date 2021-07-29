# DLL con funciones estadisticas

### Media
A partir de un vector de `int` o `double`:
```cs
double Media(double[] muestra);
double Media(int[] muestra);
```

### Media Recortada
A partir de un vector de `int` o `double`, y un porcentaje `int` de recorte
```cs
double MediaRecortada(double[] muestra, int percent);
double MediaRecortada(int[] muestra, int percent);
```

### Mediana
A partir de un vector de `int` o `double`:
```cs
double Mediana(double[] muestra);
double Mediana(int[] muestra);
```

### Moda
A partir de un vector de `int` o `double` con la/s moda/s:
```cs
List<double> Moda(double[] muestra);
List<int> Moda(int[] muestra);
```

### Simetria de la distribucion
A partir de un vector de `double`:
```cs
DistributionSimetry Simetria(double [] muestra);
```