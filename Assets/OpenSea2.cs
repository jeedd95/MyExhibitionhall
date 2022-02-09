using System;
using System.Collections.Generic;
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class PrimaryAssetContract
{
    public string address;
    public string asset_contract_type;
    public DateTime created_date;
    public string name;
    public string nft_version;
    public object opensea_version;
    public int owner;
    public string schema_name;
    public string symbol;
    public object total_supply;
    public object description;
    public object external_link;
    public object image_url;
    public bool default_to_fiat;
    public int dev_buyer_fee_basis_points;
    public int dev_seller_fee_basis_points;
    public bool only_proxied_transfers;
    public int opensea_buyer_fee_basis_points;
    public int opensea_seller_fee_basis_points;
    public int buyer_fee_basis_points;
    public int seller_fee_basis_points;
    public object payout_address;
}

public class Traits
{
}

public class Stats
{
    public double one_day_volume;
    public double one_day_change;
    public double one_day_sales;
    public double one_day_average_price;
    public double seven_day_volume;
    public double seven_day_change;
    public double seven_day_sales;
    public double seven_day_average_price;
    public double thirty_day_volume;
    public double thirty_day_change;
    public double thirty_day_sales;
    public double thirty_day_average_price;
    public double total_volume;
    public double total_sales;
    public double total_supply;
    public double count;
    public int num_owners;
    public double average_price;
    public int num_reports;
    public double market_cap;
    public int floor_price;
}

public class DisplayData2
{
    public string card_display_style;
    public List<object> images;
}

public class Collection2
{
    public List<PrimaryAssetContract> primary_asset_contracts;
    public Traits traits;
    public Stats stats;
    public object banner_image_url;
    public object chat_url;
    public DateTime created_date;
    public bool default_to_fiat;
    public object description;
    public string dev_buyer_fee_basis_points;
    public string dev_seller_fee_basis_points;
    public object discord_url;
    public DisplayData display_data;
    public object external_url;
    public bool featured;
    public object featured_image_url;
    public bool hidden;
    public string safelist_request_status;
    public object image_url;
    public bool is_subject_to_whitelist;
    public object large_image_url;
    public object medium_username;
    public string name;
    public bool only_proxied_transfers;
    public string opensea_buyer_fee_basis_points;
    public string opensea_seller_fee_basis_points;
    public object payout_address;
    public bool require_email;
    public object short_description;
    public string slug;
    public object telegram_url;
    public object twitter_username;
    public object instagram_username;
    public object wiki_url;
}

public class OpenSea2
{
    public List<Collection2> collections;
}

