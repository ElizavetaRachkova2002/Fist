
Приложение для складского учёта товаров для работы на маркетплейсе.

Данное приложение хранит информацию о различных товарах(название, штрихкод, артикул, 
бренд, количество, юридическое лицо(в дальнейнем обозначается как юр.лицо) и упаковка(упаковки) для товара.

Цель приложения - учёт товаров и упаковки для них.

Функциональность приложения:
Товары:
-Можем добавлять новые товары
-Можем изменять количество товаров, которые уже существуют(путём добавления)
-Можем удалять товары при необходимости
-Можем упаковывать товары
-Можем отправлять товары
-Можем изменять товары(название, артикул, штрихкод, юридическое лицо, бренд)
-Можем выбирать товары с браком и списывать их 
Упаковка:
-Можем добавлять новую упаковку
-Можем изменять количество существующей упаковки(увеличивать)
-МОжем удалять упаковку при необходимости

Все поля при вводе информации о товаре или упаковке должны быть заполнены, иначе
появляется сообщение об ошибке

При запуске данного приложения появляется окно, в левой части которого расположены
товары, в правой- упаковка для товаров.

Кнопки, расположенные над первой таблицей относятся к действиям, которые можно
совершить над товарами(название кнопок: добавить, упаковать, отправить, удалить,
брак, изменить)
	-Добавить	(при нажатии открывается окно, где можно выбрать какой товар добавить
			(существующий или новый))
			При незаполнении какого-либо поля или полей возникает сообщение об ошибке.
			При добавлении нового товара с существующим артикулом и штрихкодом возникает 
			сообщение о том, что данный артикул или штрихкод уже существует
			и необходимо выбрать и изменить количество данного товара в окне
			существующий товар. При добавлении нового товара можем добавить 
			или удалить юридическое лицо или бренд, нажав на кнопки, перед 
			соответствующим текстовым полем. Упаковку для товара можем выбрать
			нажав кнопку "Выбрать" в строке с упаковкой и в новом окне выбрать 
			необходимую для товара упаковку(упаковки).
	-Упаковать  (Все поля должны быть заполнены, иначе возникает сообщение об ошибкею
		      Количество товаров, подготовленных к продаже изменяют значение
			в таблице с товарами (к пятому столбцу("К продаже") прибавляют
			количество товаров, кторое ввёл пользователь в окне отправить 
			в поле - подготовлено к продаже). Если количество неупакованных
			товаров(6 столбец таблицы с товарами) больше, чем количество,
			ввседённое в в окне Упаковать в поле "Подготовлено к продаже",
			то возникает сообщение об ошибке. Количество брака увеличивает
			количество брака у выбранного товара и уменьшает общее количество
			товаров.)
	-Отправить  (Выбираем название товара и его количество, которе хотим отправить,
			оно должно бывть больше или равно количеству упакованных товаров(к продаже,
			иначе - возникает сообщение об ошибке. Мы можем отправлять несколько 
			товаров путём нажатия на кнопку "+". Также можем указывать дополнительную
			информацию при необходимости в комментарии.)
	-Удалить	(удаление данного товара).
	-Брак		(Появляется окно с товарами, которые содержат брак и их количеством.
			Можем выбрать товары путём простановки "галочек" в правой части таблицы
  			и списать выбранные товары)
	-Изменить	(Выбираем товар, который хотим изменить и нажимаем на кнопку "Просмотр"
			и изменяем данные о товаре. Все поля должны быть заполнены,
			иначе -возникает сообщение об ошибке.)

Кнопки, расположенные над второй таблицей относятся к действиям, которые можно
совершить над упаковкой(название кнопок: добавить, удалить)
	-Добавить(при нажатии открывается окно, где можно выбрать какую упаковку добавить
		(существующию или новую)).
	-Удалить(удаление данной упаковки).
		
Информация о таблицах:
	Товары:
		Столбцы:
			-Бренд
			-Артикул
			-Название		
			-Всего (Общее количество данного товара)
			-К продаже (Количество упакованного товара)
			-Не упаковано (Количество не упакованного товара)
	Упаковка:
		Столбцы:
			-Название
			-Размер (строковый тип данных)
			-Количество (Общее количество данной упаковки)


При нажатии на товар, можем увидеть подробную информацию о нём: 
наименование, юр. лицо, бренд, артикул, штрихкод, упаковка, количество брака,
количество товара, подготовлено к продаже и количество неупакованного товара.

При нажатии на упаковку, можем увидеть подробную информацию о нём: 
наименование, размер и количество

Копка история показывает историю последних действий над товарами и упаковкой

Название является строковым типом данных
Количество является целым типом (>=0)
Штрихкод является строковым типом данных, но содержит в свой записи только цифры
Артикул является строковым типом данных
Бренд является строковым типом данных
Юридического лицо является строковым типом данных 
