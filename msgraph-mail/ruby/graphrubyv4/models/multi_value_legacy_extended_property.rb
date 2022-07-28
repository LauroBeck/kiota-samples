require './models'
require 'microsoft_kiota_abstractions'
require_relative './graphrubyv4::_models::_entity'

module Graphrubyv4::Models
    class MultiValueLegacyExtendedProperty < Graphrubyv4::Models::Entity
        include MicrosoftKiotaAbstractions::Parsable
        ## 
        # A collection of property values.
        @value
        ## 
        ## Creates a new instance of the appropriate class based on discriminator value
        ## @param parseNode The parse node to use to read the discriminator value and create the object
        ## @return a multi_value_legacy_extended_property
        ## 
        def create_from_discriminator_value(parse_node) 
            return nil;
        end
        ## 
        ## The deserialization information for the current model
        ## @return a i_dictionary
        ## 
        def get_field_deserializers() 
            return super.merge({
                "value" => lambda {|o, n| o.value = n.get_collection_of_primitive_values(String) },
            })
        end
        ## 
        ## Serializes information the current object
        ## @param writer Serialization writer to use to serialize this model
        ## @return a void
        ## 
        def serialize(writer) 
            super
            writer.write_collection_of_primitive_values("value", @value)
        end
        ## 
        ## Gets the value property value. A collection of property values.
        ## @return a string
        ## 
        def  value
            return @value
        end
        ## 
        ## Sets the value property value. A collection of property values.
        ## @param value Value to set for the value property.
        ## @return a void
        ## 
        def  value=(value)
            @value = value
        end
    end
end
