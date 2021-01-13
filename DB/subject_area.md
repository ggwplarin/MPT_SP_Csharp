# Антикварная лавка
## Описание
<!-- TODO: дополнить описание -->
**Антикварный магазин** занимается продажей антиквариата с сопутствующими историями.

## Подсистемы
<!-- TODO: добавить подсистемы и их описания -->

## Список таблиц
- `shop_users` - хранит данные пользователей системы\
`shop_user_id`; `shop_user_login`; `shop_user_password` 
- `cashbox` - хранит информацию о проведенных сделках\
`sale_id`; `sale_date`; `sale_setout_position_id`; `sale_acquirer_id`
- `setout` - хранит информацию о товарах выставленных на продажу\
`setout_position_id`; `setout_position_price`; `setout_position_antique_thing_id`
- `antiques` - хранит информацию о товаре\
`antique_thing_id`; `antique_thing_title`; `antique_thing_description`; `antique_thing_storage_conditions`; `antique_thing_story_id`
- `story_archive` - хранит информацию о историях связанных с продаваемыми товарами\
`story_id`, `story_title`; `story_content`
- `acquirers` - хранит информацию о лице приобрётшем товар\
`acquirer_id`; `acquirer_first_name`; `acquirer_last_name`
<!-- TODO: добавить описание полей -->