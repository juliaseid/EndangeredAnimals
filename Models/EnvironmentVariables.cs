using System.Collections.Generic;

namespace EndangeredAnimals.Models
{
  public static class EnvironmentVariables
  {
    public static Dictionary<string, string> OurAnimals = new Dictionary<string, string>
    {
      {"Alopias pelagicus", "https://www.edgeofexistence.org/wp-content/uploads/2018/11/Alopias-pelagicus_shutterstock_240702010-1000x667.jpg"},
      {"Amazona viridigenalis","https://lh3.googleusercontent.com/proxy/XbqjsnvL6QPUSQv2rNNa1TRaig0QJ20ExXls4-eMxDLMS4XbChWoUhs4I78V3IcDTP8dXpWxWK_onpneGFa3EGtEGLLjVgVT1zN0IfHyZ4zNo9_ywP3GqrXIQt4pARMoPfLZvriEpvD8yaVGZsaZTaj3gne0r8PPnrxDMeBpzw1rPq2KcWx4z4CTatnJJPSEYVoY8loAl1QW-x32UxmspShW4A"},
      {"Ambystoma mexicanum", "https://lh3.googleusercontent.com/proxy/Pvcmm2TnC1EC9z64Ek7ApiL5AAewNuGmFI_NAIzEsCuIxTIqd4GbySeyig_g28WpZusrwGIy4sn2lq2Y9cld2WQXc3t84wE584--EbgeER9Gb4ZvSY-EuvUPGwRu1_s"},
      {"anaxyrus californicus", "https://lh3.googleusercontent.com/proxy/SNtkK_SAD-W4wOTnMzDaTsi9z4-UMsPjCkuyNa84rL3bjtQSmdCSsDRcN7CDcmXNWk0Cb6bpJjao8atRnvMSt6EzFmrCloWerUQ7SkGqRSthy_MorSWVz0OO"},
      {"Ara macao", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/Scarlet-Macaw-cr.jpg/1200px-Scarlet-Macaw-cr.jpg"},
      {"Ateles geoffroyi", "https://costa-rica-guide.com/wp-content/uploads/2015/04/IMG_1146-001.jpg"},
      {"balaenoptera musculus", "https://www.imf.org/external/pubs/ft/fandd/2019/12/images/122019/chami-index.jpg"},
      {"Bombus affinis", "https://science.sciencemag.org/content/sci/355/6323/357.1/F1.large.jpg"},
      {"Canis lupus baileyi", "https://www.knau.org/sites/knau/files/201903/mexican-gray-wolf-in-snow.jpg.990x0_q80_crop-smart.jpg"},
      {"canis rufus", "https://factor.niehs.nih.gov/2019/6/beyond-the-bench/earth-day/img869767.jpg"},
      {"Carcharhinus longimanus", "https://www.tropicalherping.com/about/photos/CC201-01-01.jpg"},
      {"Charadrius melodus", "https://upload.wikimedia.org/wikipedia/commons/0/0b/Charadrius-melodus-004_edit.jpg"},
      {"Colinus virginianus", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Virginiawachtel_2007-06-16_101.jpg/1200px-Virginiawachtel_2007-06-16_101.jpg"},
      {"Coregonus reighardi", "https://upload.wikimedia.org/wikipedia/commons/2/21/Coregonus_pidschian_cropped.jpg"},
      {"Cynomys parvidens", "https://cff2.earth.com/uploads/2017/01/03143414/Cynomys-parvidens.jpg"},
      {"Dermochelys coriacea", "https://i.pinimg.com/564x/4c/f1/45/4cf145325bc8d5a86cb1115c5d31b13d.jpg"},
      {"Epinephelus striatus", "https://oceana.org/sites/default/files/styles/lightbox_full/public/nassau_grouper.jpg?itok=sXZCtb-N"},
      {"Eubalaena glacialis", "https://oceanconservancy.org/wp-content/uploads/2018/07/39670420164_e4a5f3f836_o-2400x1600.jpg"},
      {"Euproserpinus wiesti", "https://static.inaturalist.org/photos/32802219/medium.jpg?1552526939"},
      {"Gymnogyps californianus", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/California-condor-gymnogyps-californianus-078_%2821196759264%29.jpg/1200px-California-condor-gymnogyps-californianus-078_%2821196759264%29.jpg"},
      {"Haliotis kamtschatkana", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/55/Haliotis_kamtschatkana_001.jpg/1200px-Haliotis_kamtschatkana_001.jpg"},
      {"Hemignathus affinis", "https://www.biographic.com/wp-content/uploads/2019/10/16-24-34_Iiwi_A6A3519.jpg"},
      {"Leopardus pardalis", "https://i.pinimg.com/originals/65/d6/8a/65d68aac5df9649f4655631f24167e39.jpg"},
      {"Lepidochelys kempii", "https://planeta.com/wp-content/uploads/2018/04/kempsridley.jpg"},
      {"Lithobates sevosus", "https://upload.wikimedia.org/wikipedia/commons/0/0e/Dusky_Gopher_Frog-a.jpg"},
      {"marmota vancouverensis", "https://usercontent2.hubstatic.com/8728639_f1024.jpg"},
      {"Mustela nigripes", "https://blog.nature.org/science/files/2016/01/ferrets2.jpg"},
      {"Nicrophorus americanus", "https://bloximages.chicago2.vip.townnews.com/dailyjournalonline.com/content/tncms/assets/v3/editorial/5/c3/5c342169-e67e-50a1-95f0-dc819b9bde29/598e1d6c45764.image.jpg?resize=1200%2C799"},
      {"Pristis pectinata", "https://lh3.googleusercontent.com/proxy/KuVJr-xiKBvg7qJAKtgjrG7eG-M8eJ65P43UIIL0FUcCS1wXJJpBpfw6f16CRXTrrPxODAU6OVTibEA9eCYO8JFg3GPabJbxd9NhJcW5txKC6Y7zVKU9HhbzLqxw9t_Prw"},
      {"Procyon pygmaeus", "https://content.eol.org/data/media/4c/9e/a9/18.https___www_inaturalist_org_photos_908082.jpg"},
      {"Rangifer tarandus caribou", "https://www.sciencesource.com/Doc/TR1_WATERMARKED/4/a/a/d/SS2221509.jpg?d63641658978"},
      {"Scaphirhynchus albus", "https://outdoornebraska.gov/wp-content/uploads/2018/12/Pallid-Sturgeon-NEBRASKAland-2.jpg"},
      {"Setophaga kirtlandii", "https://upload.wikimedia.org/wikipedia/commons/2/2a/Dendroica_kirtlandii_-Michigan%2C_USA_-male-8_%285%29.jpg"},
      {"Somatochlora hineana", "https://upload.wikimedia.org/wikipedia/commons/c/c1/Somatochlora_hineana_2010-1.jpg"},
      {"Strix occidentalis caurina", "https://cdn9.dissolve.com/p/D1294_11_703/D1294_11_703_1200.jpg"},
      {"Trichechus manatus", "https://www.scubadiverdestinations.com/wp-content/uploads/sites/3/2020/02/Manatee_01.jpg"}
  };


  }
}
