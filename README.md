# Otus_Dz_DataBase
Для выполнение ДЗ была выбрана БД Сбербанка.<br/>
Архитектура - Луковая (чистая).<br/>
Скрипт по созданию таблиц лежит по пути ./otus.dz.DataAccess.PostgreSQL/Migrations/<br/>
Для миграции БД необхзодимо запустить проект otus.dz.DbMigrator<br/><br/>
Настройки доступа к БД конфигурируются в ДВУХ местах:
1) launchSettings.json в проекте otus.dz.DbMigrator - для миграции
2) launchSettings.json в проекте otus.dz.WebApi - для работы проекта
