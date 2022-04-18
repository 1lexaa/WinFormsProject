using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Forms
{
    public partial class MyPatternsForm : Form
    {
        public MyPatternsForm()
        {
            InitializeComponent();
        }

        private void MyPatternsForm_Load(object sender, EventArgs e)
        {
            textBoxModel.Text = @"Поставщик данных.
Файл , база данных или веб-ресурс из которого (и в который) передаются данные для приложения.";

            textBoxView.Text = @"Интерфейс пользователя.
Набор элементов для отображения и ввода информации (в т.ч. использованием периферии";

            textBoxMVC.Text = @"Контроллер - посредник между пользователем , моделью и представлением . Пользователь через представление
взаимодействует с контроллером , он , анализируя запрос , выбирает нужную модель и нужное представление , передает пользователю
новое представление , заполненое данными из модели";


            textBoxMVP.Text = @"Presenter - соотносится с представления . Обрабатывает события (UI) и при этом общается с моделями в зависимости от событий .
Пример - WinForms : Presenter - Form.cs ; View - Form.designer; Model - сохраненные ( сериализованные ) данные";
        }
    }
}

/* Паттерны ( шаблоны ) проектирования : MVC / MVP / MVVM
 *  Паттерны - "образцы" , шаблоны , "хорошие примеры" организации проекта 
 *  Паттерны имеют название и являются популярными подходами.
 * 
 * 
 * 
 *  
 * 
 */