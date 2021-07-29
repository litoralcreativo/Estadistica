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
double MediaRecortada(double[] muestra, int percent); // media recortada a un porcentaje de un vector de dobles
double MediaRecortada(int[] muestra, int percent); // media recortada a un porcentaje de un vector de enteros
```

### Mediana
A partir de un vector de `int` o `double`:
```cs
double Mediana(double[] muestra); // devuelve la mediana de un vector de dobles
double Mediana(int[] muestra); // devuelve la mediana de un vector de enteros
```

### Moda
A partir de un vector de `int` o `double` con la/s moda/s:
```cs
List<double> Moda(double[] muestra); // devuelve una lista de la/s modas de un vector de dobles
List<int> Moda(int[] muestra); //devuelve una lista de la/s modas de un vector de enteros
```

### Simetria de la distribucion
A partir de un vector de `double`:
```cs
DistributionSimetry Simetria(double [] muestra); // devuelve una la simetria de un vector de dobles (enum type)
```