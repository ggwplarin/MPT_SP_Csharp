# Антикварная лавка
## Описание
<!-- TODO: дополнить описание -->
**Антикварный магазин** занимается продажей антиквариата с сопутствующими историями.

## Подсистемы
<!-- TODO: добавить подсистемы и их описания -->

## Список таблиц
- `users` - хранит данные пользователей системы\
    `user_id`; `user_login`; `user_password` 
- `antiques` - хранит информацию о товаре\
    `antique_thing_id`; `antique_thing_title`; `antique_thing_description`; `antique_thing_storage_conditions`; `antique_thing_story_id`
- `setout` - хранит информацию о товарах выставленных на продажу\
    `setout_position_id`; `setout_position_price`; `setout_position_antique_thing_id`
- `archive` - хранит информацию о историях связанных с продаваемыми товарами\
    `story_id`, `story_title`; `story_content`
- `cashbox` - хранит информацию о проведенных сделках\
    `sale_id`; `sale_date`; `sale_setout_position_id`; `sale_acquirer_id`
- `acquirers` - хранит информацию о лице приобрётшем товар\
    `acquirer_id`; `acquirer_first_name`; `acquirer_last_name`
<!--//- stockroom - хранит информацию о товарах находящихся на складе - -->
<!-- TODO: добавить описание полей -->