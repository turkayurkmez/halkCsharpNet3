﻿// See https://aka.ms/new-console-template for more information
using LiskovSubstution;

Console.WriteLine("Hello, World!");
/*
 * Bir sınıf; başka bir sınıftan türemiş ise; O sınıflardan oluşan nesneler birbirlerinin yerine kullanılabilmeli.
 * Başka bir değişle; Bir derived sınıf, base sınıf ÖZELLİKLERİ üzerinde değişiklik YAPAMAZ!
 * 
 */

var rectangle = new GeometryLibrary().RectangleFactory(5, 12);
Console.WriteLine(rectangle.GetArea());






