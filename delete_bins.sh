#!/bin/bash

deleted=0

for folder in TASK_*/; do
    if [ -d "${folder}bin" ]; then
        rm -rf "${folder}bin"
        ((deleted++))
    fi
done

echo "Удалено bin директорий: $deleted"

rm -- "$0"
