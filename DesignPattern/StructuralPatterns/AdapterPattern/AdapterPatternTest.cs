using DesignPattern.StructuralPatterns.AdapterPattern.AnimalExample;
using NUnit.Framework;

namespace DesignPattern.StructuralPatterns.AdapterPattern;
// 结构型模式

/// <summary>
/// 适配器模式
/// 测试类
/// </summary>
[TestFixture]
public class AdapterPatternTest
{
    [Test]
    public void TestAnimalExample()
    {
        IAnimal dog = new Dog();
        IAnimal cat = new Cat();
        IPerson student = new Student("小明");
        IPerson teacher = new Teacher("张美丽");
        dog.Sound();
        cat.Sound();
        student.Speak();
        teacher.Speak();

        IAnimal studentAnimal = new AnimalAdapter(student);
        IAnimal teacherAnimal = new AnimalAdapter(teacher);

        studentAnimal.Sound();
        teacherAnimal.Sound();
    }
}