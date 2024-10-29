using ProxySample1;

IImage image = new ProxyImage("test_image.jpg");

// تصویر هنوز بارگذاری نشده است
Console.WriteLine("Image object created but not loaded.");

// اولین بار که نیاز به نمایش داریم، تصویر بارگذاری می‌شود
Console.WriteLine("\nFirst time display:");
image.Display();

// بار دوم تصویر بدون بارگذاری مجدد نمایش داده می‌شود
Console.WriteLine("\nSecond time display:");
image.Display();