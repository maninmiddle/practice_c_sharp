#!/bin/bash

if [ $# -eq 0 ]; then
    echo "Ошибка: Не указано количество папок"
    echo "Использование: $0 <число>"
    exit 1
fi

if ! [[ $1 =~ ^[0-9]+$ ]] || [ $1 -eq 0 ]; then
    echo "Ошибка: Аргумент должен быть положительным числом"
    exit 1
fi

count=$1

echo "Создаю $count папок..."

for ((i=1; i<=count; i++)); do
    folder_name="TASK_$i"
    mkdir -p "$folder_name"
    
    if [ $? -eq 0 ]; then
        echo "✓ Создана папка: $folder_name"
    else
        echo "✗ Ошибка при создании: $folder_name"
        exit 1
    fi
done

echo "Готово! Создано $count папок."

echo "Самоудаляюсь..."
rm -- "$0"

if [ $? -eq 0 ]; then
    echo "✓ Скрипт успешно удален"
else
    echo "✗ Ошибка при самоудалении"
    exit 1
fi
